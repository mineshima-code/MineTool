using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MineTool
{
    public partial class Form1 : Form
    {
        private Process currentProcess;
        private bool stopPortScanner = false;
        private bool stopPingSweep = false;
        private class PortRiskInfo
        {
            public string Service { get; set; }
            public string Severity { get; set; }
            public string Message { get; set; }

            public PortRiskInfo(string service, string severity, string message)
            {
                Service = service;
                Severity = severity;
                Message = message;
            }
        }
        private Dictionary<int, PortRiskInfo> riskyPorts = new Dictionary<int, PortRiskInfo>()
{
    {21,   new PortRiskInfo("FTP", "★★★☆☆ MEDIUM",
        "平文で認証情報が送信されます。SFTPの利用を推奨します。")},

    {23,   new PortRiskInfo("Telnet", "★★★★★ HIGH",
        "通信が暗号化されません。SSHへ移行してください。")},

    {25,   new PortRiskInfo("SMTP", "★★☆☆☆ LOW",
        "メールサーバ以外で公開する必要は通常ありません。")},

    {53,   new PortRiskInfo("DNS", "★☆☆☆☆ INFO",
        "DNSサービスです。公開用途以外では不要な場合があります。")},

    {80,   new PortRiskInfo("HTTP", "★★☆☆☆ LOW",
        "HTTPは暗号化されません。HTTPSを推奨します。")},

    {110,  new PortRiskInfo("POP3", "★★★☆☆ MEDIUM",
        "POP3は平文通信となる場合があります。")},

    {143,  new PortRiskInfo("IMAP", "★★★☆☆ MEDIUM",
        "暗号化(IMAPS)を利用してください。")},

    {443,  new PortRiskInfo("HTTPS", "★☆☆☆☆ SAFE",
        "HTTPSサービスです。証明書管理を適切に行ってください。")},

    {445,  new PortRiskInfo("SMB", "★★★★★ HIGH",
        "ランサムウェアで悪用されることがあります。インターネット公開は避けてください。")},

    {3306, new PortRiskInfo("MySQL", "★★★★☆ HIGH",
        "データベースを直接公開することは推奨されません。")},

    {3389, new PortRiskInfo("RDP", "★★★★★ HIGH",
        "総当たり攻撃の対象になりやすいです。VPN経由を推奨します。")},

    {5432, new PortRiskInfo("PostgreSQL", "★★★★☆ HIGH",
        "データベースを直接公開しないでください。")},

    {5900, new PortRiskInfo("VNC", "★★★★☆ HIGH",
        "認証設定を確認してください。公開は非推奨です。")},

    {6379, new PortRiskInfo("Redis", "★★★★★ HIGH",
        "認証なし公開は非常に危険です。")},

    {9200, new PortRiskInfo("Elasticsearch", "★★★★★ HIGH",
        "認証なし公開による情報漏えい事例があります。")}
};
        private Dictionary<int, string> serviceNames = new Dictionary<int, string>()
{
    {21, "FTP"},
    {22, "SSH"},
    {23, "Telnet"},
    {25, "SMTP"},
    {53, "DNS"},
    {80, "HTTP"},
    {110, "POP3"},
    {135, "RPC"},
    {139, "NetBIOS"},
    {143, "IMAP"},
    {389, "LDAP"},
    {443, "HTTPS"},
    {445, "SMB"},
    {1433, "SQL Server"},
    {3306, "MySQL"},
    {3389, "RDP"},
    {5432, "PostgreSQL"},
    {5900, "VNC"},
    {8080, "HTTP Alt"}
};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();

            if (host == "")
            {
                textBox1.Text = "接続先を入力してください。";
                return;
            }

            textBox1.Clear();
            stopPingSweep = false;
            AddLog("Ping開始: " + host);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "ping";
            psi.Arguments = chkContinuous.Checked ? "-t " + host : host;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            psi.StandardOutputEncoding = Encoding.GetEncoding("shift_jis");

            currentProcess = new Process();
            currentProcess.StartInfo = psi;
            currentProcess.EnableRaisingEvents = true;

            currentProcess.OutputDataReceived += (s, ev) =>
            {
                if (ev.Data != null)
                {
                    this.Invoke(new Action(() =>
                    {
                        textBox1.AppendText(ev.Data + "\r\n");
                    }));
                }
            };

            currentProcess.Start();
            currentProcess.BeginOutputReadLine();
        }
        private void AddLog(string message)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action(() => AddLog(message)));
                return;
            }

            string time = DateTime.Now.ToString("HH:mm:ss");
            textBox1.AppendText($"[{time}] {message}\r\n");
        }
        private void RunCommand(string fileName, string arguments)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = fileName;
                psi.Arguments = arguments;
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;
                psi.StandardOutputEncoding = Encoding.GetEncoding("shift_jis");
                psi.StandardErrorEncoding = Encoding.GetEncoding("shift_jis");

                Process process = new Process();
                process.StartInfo = psi;

                process.OutputDataReceived += (s, ev) =>
                {
                    if (ev.Data != null)
                    {
                        this.Invoke(new Action(() =>
                        {
                            AddLog(ev.Data);
                        }));
                    }
                };

                process.ErrorDataReceived += (s, ev) =>
                {
                    if (ev.Data != null)
                    {
                        this.Invoke(new Action(() =>
                        {
                            AddLog("ERROR: " + ev.Data);
                        }));
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                AddLog("コマンド実行エラー: " + ex.Message);
            }
        }
        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Ping Sweep停止
            stopPingSweep = true;

            // ping -t 停止
            if (currentProcess != null && !currentProcess.HasExited)
            {
                currentProcess.Kill();
                AddLog("Pingを停止しました。");
            }
        }

        private void btnRdp_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();

            if (host == "")
            {
                textBox1.AppendText("RDP接続先を入力してください。\r\n");
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "mstsc";
            psi.Arguments = "/v:" + host;
            psi.UseShellExecute = true;

            Process.Start(psi);

            AddLog("RDP接続を起動しました: " + host);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            splitContainer1.Panel2.Controls.Add(textBox1);
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Height = 250;
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            btnPingRun.Click -= btnPingRun_Click;
            btnPingRun.Click += btnPingRun_Click;
            btnPingStop.Click -= btnPingStop_Click;
            btnPingStop.Click += btnPingStop_Click;
            btnPingSweepRun.Click -= btnPingSweepRun_Click;
            btnPingSweepRun.Click += btnPingSweepRun_Click;
            btnPingSweepStop.Click -= btnPingSweepStop_Click;
            btnPingSweepStop.Click += btnPingSweepStop_Click;
            btnNslookupRun.Click -= btnNslookupRun_Click;
            btnNslookupRun.Click += btnNslookupRun_Click;
            btnTracertRun.Click -= btnTracertRun_Click;
            btnTracertRun.Click += btnTracertRun_Click;
            btnTracertStop.Click -= btnTracertStop_Click;
            btnTracertStop.Click += btnTracertStop_Click;
            btnTcpPortRun.Click -= btnTcpPortRun_Click;
            btnTcpPortRun.Click += btnTcpPortRun_Click;
            btnArpRun.Click -= btnArpRun_Click;
            btnArpRun.Click += btnArpRun_Click;
            btnNetstatRun.Click -= btnNetstatRun_Click;
            btnNetstatRun.Click += btnNetstatRun_Click;
            btnEventViewerRun.Click -= btnEventViewerRun_Click;
            btnEventViewerRun.Click += btnEventViewerRun_Click;
            btnEventViewerSystem.Click -= btnEventViewerSystem_Click;
            btnEventViewerSystem.Click += btnEventViewerSystem_Click;
            btnEventViewerApplication.Click -= btnEventViewerApplication_Click;
            btnEventViewerApplication.Click += btnEventViewerApplication_Click;
            btnEventViewerSecurity.Click -= btnEventViewerSecurity_Click;
            btnEventViewerSecurity.Click += btnEventViewerSecurity_Click;
            btnServicesRun.Click -= btnServicesRun_Click;
            btnServicesRun.Click += btnServicesRun_Click;
            btnComputerManagementRun.Click -= btnComputerManagementRun_Click;
            btnComputerManagementRun.Click += btnComputerManagementRun_Click;
            btnDeviceManagerRun.Click -= btnDeviceManagerRun_Click;
            btnDeviceManagerRun.Click += btnDeviceManagerRun_Click;
            btnDiskManagementRun.Click -= btnDiskManagementRun_Click;
            btnDiskManagementRun.Click += btnDiskManagementRun_Click;
            btnLocalUsersRun.Click -= btnLocalUsersRun_Click;
            btnLocalUsersRun.Click += btnLocalUsersRun_Click;
            btnRemoteDesktopRun.Click -= btnRemoteDesktopRun_Click;
            btnRemoteDesktopRun.Click += btnRemoteDesktopRun_Click;
            btnPortScannerRun.Click -= btnPortScannerRun_Click;
            btnPortScannerRun.Click += btnPortScannerRun_Click;
            btnPortScannerStop.Click -= btnPortScannerStop_Click;
            btnPortScannerStop.Click += btnPortScannerStop_Click;
            btnGenerateHash.Click -= btnGenerateHash_Click;
            btnGenerateHash.Click += btnGenerateHash_Click;
            btnCopyHash.Click -= btnCopyHash_Click;
            btnCopyHash.Click += btnCopyHash_Click;
            txtPassword.KeyDown -= txtPassword_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.TextChanged -= txtPassword_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;
            UpdatePasswordLength();
            ShowPanel(panelHome, "MineTool");

        }

        private void btnEventViewer_Click(object sender, EventArgs e)
        {
            Process.Start("eventvwr.exe");
            AddLog("イベントビューアを起動しました。");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
            AddLog("サービスを起動しました。");
        }

        private void btnComputerManagement_Click(object sender, EventArgs e)
        {
            Process.Start("compmgmt.msc");
            AddLog("コンピューターの管理を起動しました。");
        }

        private void btnNslookup_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();

            if (host == "")
            {
                AddLog("接続先を入力してください。");
                return;
            }

            textBox1.Clear();
            AddLog("nslookup開始: " + host);

            RunCommand("nslookup", host);
        }

        private void btnTracert_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();

            if (host == "")
            {
                AddLog("接続先を入力してください。");
                return;
            }

            textBox1.Clear();
            AddLog("tracert開始: " + host);

            RunCommand("tracert", host);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnPortcktcp_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text.Trim();
            string portText = txtPort.Text.Trim();

            if (host == "")
            {
                AddLog("接続先を入力してください。");
                return;
            }

            textBox1.Clear();

            if (portText == "")
            {
                AddLog("よく使うTCPポート確認開始: " + host);

                int[] ports =
                {
            21, 22, 23, 25, 53, 80, 110,
            135, 139, 143, 389, 443, 445,
            1433, 3306, 3389, 5432, 5900, 8080
        };

                foreach (int p in ports)
                {
                    await CheckTcpPort(host, p);
                }

                AddLog("よく使うTCPポート確認完了");
            }
            else
            {
                if (!int.TryParse(portText, out int port))
                {
                    AddLog("ポート番号を正しく入力してください。");
                    return;
                }

                AddLog($"TCPポート確認開始: {host}:{port}");
                await CheckTcpPort(host, port);
                AddLog("TCPポート確認完了");
            }
        }
        private async Task CheckTcpPort(string host, int port)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    Task connectTask = client.ConnectAsync(host, port);
                    Task timeoutTask = Task.Delay(1000);

                    Task finishedTask = await Task.WhenAny(connectTask, timeoutTask);

                    if (finishedTask == connectTask && client.Connected)
                    {
                        string service = "Unknown";

                        if (serviceNames.ContainsKey(port))
                        {
                            service = serviceNames[port];
                        }

                        AddLog($"OPEN : {port} ({service})");
                    }
                }
            }
            catch
            {
                // 閉じているポートは表示しない
            }
        }
        private uint IpToUInt(IPAddress ip)
        {
            byte[] bytes = ip.GetAddressBytes();

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToUInt32(bytes, 0);
        }

        private string UIntToIp(uint ip)
        {
            byte[] bytes = BitConverter.GetBytes(ip);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return new IPAddress(bytes).ToString();
        }

        private async void btnPingSweep_Click(object sender, EventArgs e)
        {
            string startIpText = txtStartIp.Text.Trim();
            string endIpText = txtEndIp.Text.Trim();

            if (!IPAddress.TryParse(startIpText, out IPAddress startIp) ||
                !IPAddress.TryParse(endIpText, out IPAddress endIp))
            {
                AddLog("開始IPまたは終了IPが正しくありません。");
                return;
            }

            textBox1.Clear();
            AddLog("Ping Sweep開始: " + startIpText + " ～ " + endIpText);

            uint start = IpToUInt(startIp);
            uint end = IpToUInt(endIp);

            if (start > end)
            {
                AddLog("開始IPが終了IPより大きいです。");
                return;
            }

            for (uint ip = start; ip <= end; ip++)
            {
                if (stopPingSweep)
                {
                    AddLog("Ping Sweepを停止しました。");
                    break;
                }
                string target = UIntToIp(ip);

                using (Ping ping = new Ping())
                {
                    try
                    {
                        PingReply reply = await ping.SendPingAsync(target, 500);

                        if (reply.Status == IPStatus.Success)
                        {
                            AddLog("OK : " + target);
                        }
                    }
                    catch
                    {
                        // 応答なしは表示しない
                    }
                }
            }

            AddLog("Ping Sweep完了");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HideAllPanels();

            switch (e.Node.Text)
            {
                case "Ping":
                    ShowPanel(panelPing, "Ping");
                    break;

                case "Ping Sweep":
                    ShowPanel(panelPingSweep, "Ping Sweep");
                    break;
                case "nslookup":
                    ShowPanel(panelNslookup, "nslookup");
                    break;
                case "tracert":
                    ShowPanel(paneltracert, "tracert");
                    break;
                case "TCP Port":
                    ShowPanel(panelTcpPort, "TCP Port");
                    break;
                case "ARP":
                    ShowPanel(panelArp, "ARP");
                    break;
                case "Netstat":
                    ShowPanel(panelNetstat, "Netstat");
                    break;
                case "Event Viewer":
                    ShowPanel(panelEventViewer, "Event Viewer");
                    break;
                case "Services":
                    ShowPanel(panelServices, "Services");
                    break;
                case "Computer Management":
                    ShowPanel(panelComputerManagement, "Computer Management");
                    break;
                case "Device Manager":
                    ShowPanel(panelDeviceManager, "Device Manager");
                    break;
                case "Disk Management":
                    ShowPanel(panelDiskManagement, "Disk Management");
                    break;
                case "Local Users":
                    ShowPanel(panelLocalUsers, "Local Users");
                    break;
                case "Remote Desktop":
                    ShowPanel(panelRemoteDesktop, "Remote Desktop");
                    break;
                case "Port Scanner":
                    ShowPanel(panelPortScanner, "Port Scanner");
                    break;
                case "Password Hash Utility":
                    ShowPanel(panelPasswordHashUtility, "Password Hash Utility");
                    break;
            }

            AddLog("選択：" + e.Node.Text);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HideAllPanels()
        {
            panelHome.Visible = false;
            panelPing.Visible = false;
            panelPingSweep.Visible = false;
            panelNslookup.Visible = false;
            paneltracert.Visible = false;
            panelTcpPort.Visible = false;
            panelArp.Visible = false;
            panelNetstat.Visible = false;
            panelEventViewer.Visible = false;
            panelServices.Visible = false;
            panelComputerManagement.Visible = false;
            panelDeviceManager.Visible = false;
            panelDiskManagement.Visible = false;
            panelLocalUsers.Visible = false;
            panelRemoteDesktop.Visible = false;
            panelPortScanner.Visible = false;
            panelPasswordHashUtility.Visible = false;

        }
        private void ShowPanel(Panel panel, string title)
        {
            HideAllPanels();

            panel.Visible = true;
            lblTitle.Text = title;
        }

        private void btnPingRun_Click(object sender, EventArgs e)
        {
            string host = txtPingHost.Text.Trim();

            if (host == "")
            {
                AddLog("Ping先を入力してください。");
                return;
            }

            AddLog("Ping開始 : " + host);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "ping.exe";
            psi.Arguments = chkPingContinuous.Checked ? "-t " + host : host;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.StandardOutputEncoding = Encoding.GetEncoding("shift_jis");

            Process p = new Process();
            p.StartInfo = psi;
            currentProcess = p;

            p.OutputDataReceived += (s, ev) =>
            {
                if (ev.Data != null)
                {
                    this.Invoke(new Action(() =>
                    {
                        AddLog(ev.Data);
                    }));
                }
            };

            p.Start();
            p.BeginOutputReadLine();
        }

        private void btnPingStop_Click(object sender, EventArgs e)
        {
            if (currentProcess != null && !currentProcess.HasExited)
            {
                currentProcess.Kill();
                AddLog("Pingを停止しました。");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void btnPingSweepRun_Click(object sender, EventArgs e)
        {
            string startIpText = txtSweepStartIp.Text.Trim();
            string endIpText = txtSweepEndIp.Text.Trim();

            if (!IPAddress.TryParse(startIpText, out IPAddress startIp) ||
                !IPAddress.TryParse(endIpText, out IPAddress endIp))
            {
                AddLog("開始IPまたは終了IPが正しくありません。");
                return;
            }

            textBox1.Clear();
            stopPingSweep = false;

            AddLog("Ping Sweep開始: " + startIpText + " ～ " + endIpText);

            uint start = IpToUInt(startIp);
            uint end = IpToUInt(endIp);

            if (start > end)
            {
                AddLog("開始IPが終了IPより大きいです。");
                return;
            }

            for (uint ip = start; ip <= end; ip++)
            {
                if (stopPingSweep)
                {
                    AddLog("Ping Sweepを停止しました。");
                    break;
                }

                string target = UIntToIp(ip);

                using (Ping ping = new Ping())
                {
                    try
                    {
                        PingReply reply = await ping.SendPingAsync(target, 500);

                        if (reply.Status == IPStatus.Success)
                        {
                            AddLog("OK : " + target);
                        }
                    }
                    catch
                    {
                        // 応答なしは表示しない
                    }
                }
            }

            AddLog("Ping Sweep完了");
        }

        private void btnPingSweepStop_Click(object sender, EventArgs e)
        {
            stopPingSweep = true;
        }

        private void btnNslookupRun_Click(object sender, EventArgs e)
        {
            string host = txtNslookupHost.Text.Trim();

            if (host == "")
            {
                AddLog("Host/IPを入力してください。");
                return;
            }

            textBox1.Clear();

            AddLog("nslookup開始 : " + host);

            RunCommand("nslookup.exe", host);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnTracertRun_Click(object sender, EventArgs e)
        {
            string host = txtTracertHost.Text.Trim();

            if (host == "")
            {
                AddLog("Host/IPを入力してください。");
                return;
            }

            textBox1.Clear();

            AddLog("tracert開始 : " + host);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "tracert.exe";
            psi.Arguments = host;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.StandardOutputEncoding = Encoding.GetEncoding("shift_jis");

            currentProcess = new Process();
            currentProcess.StartInfo = psi;

            currentProcess.OutputDataReceived += (s, ev) =>
            {
                if (ev.Data != null)
                {
                    Invoke(new Action(() =>
                    {
                        AddLog(ev.Data);
                    }));
                }
            };

            currentProcess.Start();
            currentProcess.BeginOutputReadLine();
        }

        private void btnTracertStop_Click(object sender, EventArgs e)
        {
            if (currentProcess != null && !currentProcess.HasExited)
            {
                currentProcess.Kill();
                AddLog("tracertを停止しました。");
            }
        }

        private async void btnTcpPortRun_Click(object sender, EventArgs e)
        {
            string host = txtTcpHost.Text.Trim();
            string portText = txtTcpPort.Text.Trim();

            if (host == "")
            {
                AddLog("接続先を入力してください。");
                return;
            }

            textBox1.Clear();

            if (portText == "")
            {
                AddLog("よく使うTCPポート確認開始: " + host);

                int[] ports =
                {
            21, 22, 23, 25, 53, 80, 110,
            135, 139, 143, 389, 443, 445,
            1433, 3306, 3389, 5432, 5900, 8080
        };

                foreach (int p in ports)
                {
                    await CheckTcpPort(host, p);
                }

                AddLog("よく使うTCPポート確認完了");
            }
            else
            {
                if (!int.TryParse(portText, out int port))
                {
                    AddLog("ポート番号を正しく入力してください。");
                    return;
                }

                AddLog($"TCPポート確認開始: {host}:{port}");
                await CheckTcpPort(host, port);
                AddLog("TCPポート確認完了");
            }
        }

        private void btnArpRun_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (string.IsNullOrWhiteSpace(txtArpHost.Text))
            {
                AddLog("ARPテーブル取得");
                RunCommand("arp.exe", "-a");
            }
            else
            {
                AddLog("ARP取得 : " + txtArpHost.Text);
                RunCommand("arp.exe", "-a " + txtArpHost.Text.Trim());
            }
        }

        private void btnNetstatRun_Click(object sender, EventArgs e)
        {
            string args = "";

            if (chkNetstatAll.Checked)
                args += "-a ";

            if (chkNetstatNumeric.Checked)
                args += "-n ";

            textBox1.Clear();

            AddLog("netstat開始 : " + args.Trim());

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "netstat.exe";
            psi.Arguments = args.Trim();
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.StandardOutputEncoding = Encoding.GetEncoding("shift_jis");

            currentProcess = new Process();
            currentProcess.StartInfo = psi;

            currentProcess.OutputDataReceived += (s, ev) =>
            {
                if (ev.Data != null)
                {
                    Invoke(new Action(() =>
                    {
                        AddLog(ev.Data);
                    }));
                }
            };

            currentProcess.Start();
            currentProcess.BeginOutputReadLine();
        }

        private void btnNetstatStop_Click(object sender, EventArgs e)
        {
            if (currentProcess != null && !currentProcess.HasExited)
            {
                currentProcess.Kill();
                AddLog("netstatを停止しました。");
            }
        }

        private void btnEventViewerRun_Click(object sender, EventArgs e)
        {
            Process.Start("eventvwr.exe");
            AddLog("イベントビューアを起動しました。");
        }

        private void btnEventViewerSystem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "eventvwr.exe",
                Arguments = "/c:System",
                UseShellExecute = true
            });

            AddLog("Systemログを開きました。");
        }

        private void btnEventViewerApplication_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "eventvwr.exe",
                Arguments = "/c:Application",
                UseShellExecute = true
            });

            AddLog("Applicationログを開きました。");
        }

        private void btnEventViewerSecurity_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "eventvwr.exe",
                Arguments = "/c:Security",
                UseShellExecute = true
            });

            AddLog("Securityログを開きました。");
        }

        private void btnServicesRun_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
            AddLog("サービスを起動しました。");
        }

        private void btnComputerManagementRun_Click(object sender, EventArgs e)
        {
            Process.Start("compmgmt.msc");
            AddLog("コンピューターの管理を起動しました。");
        }

        private void btnDeviceManagerRun_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");

            AddLog("デバイスマネージャーを起動しました。");
        }

        private void btnDiskManagementRun_Click(object sender, EventArgs e)
        {
            Process.Start("diskmgmt.msc");

            AddLog("ディスクの管理を起動しました。");
        }

        private void btnLocalUsersRun_Click(object sender, EventArgs e)
        {
            Process.Start("lusrmgr.msc");

            AddLog("ローカルユーザーとグループを起動しました。");
        }

        private void btnRemoteDesktopRun_Click(object sender, EventArgs e)
        {
            string host = txtRemoteDesktopHost.Text.Trim();

            if (host == "")
            {
                AddLog("接続先を入力してください。");
                return;
            }

            Process.Start("mstsc.exe", "/v:" + host);

            AddLog("リモートデスクトップ接続を起動しました: " + host);
        }
        private async void btnPortScannerRun_Click(object sender, EventArgs e)
        {
            string host = txtPortScannerHost.Text.Trim();
            string startText = txtPortScannerStartPort.Text.Trim();
            string endText = txtPortScannerEndPort.Text.Trim();

            if (host == "")
            {
                AddLog("Host/IPを入力してください。");
                return;
            }

            if (!int.TryParse(startText, out int startPort) ||
                !int.TryParse(endText, out int endPort))
            {
                AddLog("開始ポートまたは終了ポートを正しく入力してください。");
                return;
            }

            if (startPort < 1 || endPort > 65535 || startPort > endPort)
            {
                AddLog("ポート範囲は 1 ～ 65535 で指定してください。");
                return;
            }

            textBox1.Clear();
            stopPortScanner = false;

            AddLog($"Port Scanner開始: {host} {startPort}～{endPort}");

            int maxParallel = 100;
            int timeout = 300;

            SemaphoreSlim semaphore = new SemaphoreSlim(maxParallel);
            List<Task> tasks = new List<Task>();

            for (int port = startPort; port <= endPort; port++)
            {
                if (stopPortScanner)
                {
                    AddLog("Port Scannerを停止しました。");
                    break;
                }

                int currentPort = port;

                Task task = Task.Run(async () =>
                {
                    await semaphore.WaitAsync();

                    try
                    {
                        if (!stopPortScanner)
                        {
                            await ScanPort(host, currentPort, timeout);
                        }
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });

                tasks.Add(task);
            }

            await Task.WhenAll(tasks);

            AddLog("Port Scanner完了");
        }

        private void btnPortScannerStop_Click(object sender, EventArgs e)
        {
            stopPortScanner = true;
            AddLog("Port Scanner停止要求");
        }
        private async Task ScanPort(string host, int port, int timeout)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    Task connectTask = client.ConnectAsync(host, port);
                    Task timeoutTask = Task.Delay(timeout);

                    Task finishedTask = await Task.WhenAny(connectTask, timeoutTask);

                    if (finishedTask == connectTask && client.Connected)
                    {
                        string service = serviceNames.ContainsKey(port)
                            ? serviceNames[port]
                            : "Unknown";

                        StringBuilder sb = new StringBuilder();

                        sb.AppendLine($"OPEN : {port} ({service})");

                        if (riskyPorts.TryGetValue(port, out PortRiskInfo risk))
                        {
                            sb.AppendLine("--------------------------------");
                            sb.AppendLine($"危険度 : {risk.Severity}");
                            sb.AppendLine(risk.Message);
                            sb.AppendLine("--------------------------------");
                        }

                        AddLog(sb.ToString().TrimEnd());
                    }
                }
            }
            catch
            {
                // CLOSED/応答なしは表示しない
            }
        }

        private void btnGenerateHash_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                txtHash.Clear();
                AddLog("Passwordを入力してください。");
                MessageBox.Show("Passwordを入力してください。", "MineTool",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string algorithm = "";

            if (rdoMD5.Checked) algorithm = "MD5";
            else if (rdoSHA1.Checked) algorithm = "SHA1";
            else if (rdoSHA256.Checked) algorithm = "SHA256";
            else if (rdoSHA384.Checked) algorithm = "SHA384";
            else if (rdoSHA512.Checked) algorithm = "SHA512";
            else
            {
                AddLog("Algorithmを選択してください。");
                return;
            }

            string hash = GenerateHash(password, algorithm);

            txtHash.Text = hash;
            AddLog($"{algorithm} hash generated.");
        }

        private string GenerateHash(string input, string algorithm)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes;

            switch (algorithm)
            {
                case "MD5":
                    using (MD5 md5 = MD5.Create())
                    {
                        hashBytes = md5.ComputeHash(bytes);
                    }
                    break;

                case "SHA1":
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        hashBytes = sha1.ComputeHash(bytes);
                    }
                    break;

                case "SHA256":
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        hashBytes = sha256.ComputeHash(bytes);
                    }
                    break;

                case "SHA384":
                    using (SHA384 sha384 = SHA384.Create())
                    {
                        hashBytes = sha384.ComputeHash(bytes);
                    }
                    break;

                case "SHA512":
                    using (SHA512 sha512 = SHA512.Create())
                    {
                        hashBytes = sha512.ComputeHash(bytes);
                    }
                    break;

                default:
                    throw new ArgumentException("未対応のアルゴリズムです。");
                    
            }

            StringBuilder sb = new StringBuilder();

            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private void btnCopyHash_Click(object sender, EventArgs e)
        {
            if (txtHash.Text == "")
            {
                AddLog("コピーするHashがありません。");
                return;
            }

            Clipboard.SetText(txtHash.Text);
            AddLog("Hashをクリップボードにコピーしました。");
            MessageBox.Show("Hashをクリップボードにコピーしました。", "MineTool",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerateHash_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordLength();
        }

        private void UpdatePasswordLength()
        {
            lblPassword.Text = $"Password ({txtPassword.Text.Length} chars)";
        }
    }
}


