namespace MineTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ping");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ping Sweep");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("nslookup");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("tracert");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("TCP Port");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ARP");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Event Viewer");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Services");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Computer Management");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Device Manager");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Disk Management");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Local Users");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Windows", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Remote Desktop");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Remote", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Server");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Port Scanner");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Password Hash Utility");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("File Finder");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Mine Tool", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.chkContinuous = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRdp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPingSweep = new System.Windows.Forms.Button();
            this.btnNslookup = new System.Windows.Forms.Button();
            this.btnTracert = new System.Windows.Forms.Button();
            this.btnPortcktcp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtStartIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndIp = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelFileFinder = new System.Windows.Forms.Panel();
            this.chkFileFinderEverything = new System.Windows.Forms.CheckBox();
            this.lblFileFinderStatus = new System.Windows.Forms.Label();
            this.lstFileFinderResults = new System.Windows.Forms.ListBox();
            this.txtFileFinderPattern = new System.Windows.Forms.TextBox();
            this.lblFileFinderPattern = new System.Windows.Forms.Label();
            this.btnFileFinderStop = new System.Windows.Forms.Button();
            this.btnFileFinderRun = new System.Windows.Forms.Button();
            this.txtFileFinderKeyword = new System.Windows.Forms.TextBox();
            this.btnFileFinderBrowse = new System.Windows.Forms.Button();
            this.lblFileFinderKeyword = new System.Windows.Forms.Label();
            this.txtFileFinderPath = new System.Windows.Forms.TextBox();
            this.lblFileFinderPath = new System.Windows.Forms.Label();
            this.panelPasswordHashUtility = new System.Windows.Forms.Panel();
            this.btnCopyHash = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.btnGenerateHash = new System.Windows.Forms.Button();
            this.grpAlgorithm = new System.Windows.Forms.GroupBox();
            this.rdoMD5 = new System.Windows.Forms.RadioButton();
            this.rdoSHA1 = new System.Windows.Forms.RadioButton();
            this.rdoSHA256 = new System.Windows.Forms.RadioButton();
            this.rdoSHA384 = new System.Windows.Forms.RadioButton();
            this.rdoSHA512 = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelPortScanner = new System.Windows.Forms.Panel();
            this.btnPortScannerStop = new System.Windows.Forms.Button();
            this.btnPortScannerRun = new System.Windows.Forms.Button();
            this.txtPortScannerEndPort = new System.Windows.Forms.TextBox();
            this.txtPortScannerStartPort = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtPortScannerHost = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panelRemoteDesktop = new System.Windows.Forms.Panel();
            this.btnRemoteDesktopRun = new System.Windows.Forms.Button();
            this.txtRemoteDesktopHost = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panelLocalUsers = new System.Windows.Forms.Panel();
            this.btnLocalUsersRun = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.panelDiskManagement = new System.Windows.Forms.Panel();
            this.btnDiskManagementRun = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.panelDeviceManager = new System.Windows.Forms.Panel();
            this.btnDeviceManagerRun = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panelComputerManagement = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnComputerManagementRun = new System.Windows.Forms.Button();
            this.panelServices = new System.Windows.Forms.Panel();
            this.btnServicesRun = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panelEventViewer = new System.Windows.Forms.Panel();
            this.btnEventViewerSecurity = new System.Windows.Forms.Button();
            this.btnEventViewerApplication = new System.Windows.Forms.Button();
            this.btnEventViewerSystem = new System.Windows.Forms.Button();
            this.btnEventViewerRun = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.panelNetstat = new System.Windows.Forms.Panel();
            this.btnNetstatStop = new System.Windows.Forms.Button();
            this.btnNetstatRun = new System.Windows.Forms.Button();
            this.chkNetstatNumeric = new System.Windows.Forms.CheckBox();
            this.chkNetstatAll = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panelArp = new System.Windows.Forms.Panel();
            this.btnArpRun = new System.Windows.Forms.Button();
            this.txtArpHost = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelTcpPort = new System.Windows.Forms.Panel();
            this.btnTcpPortRun = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.txtTcpHost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.paneltracert = new System.Windows.Forms.Panel();
            this.btnTracertStop = new System.Windows.Forms.Button();
            this.btnTracertRun = new System.Windows.Forms.Button();
            this.txtTracertHost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelWork = new System.Windows.Forms.Panel();
            this.panelPing = new System.Windows.Forms.Panel();
            this.btnPingStop = new System.Windows.Forms.Button();
            this.chkPingContinuous = new System.Windows.Forms.CheckBox();
            this.lblPingTitle = new System.Windows.Forms.Label();
            this.btnPingRun = new System.Windows.Forms.Button();
            this.txtPingHost = new System.Windows.Forms.TextBox();
            this.panelPingSweep = new System.Windows.Forms.Panel();
            this.lblPingSweep = new System.Windows.Forms.Label();
            this.btnPingSweepStop = new System.Windows.Forms.Button();
            this.btnPingSweepRun = new System.Windows.Forms.Button();
            this.txtSweepEndIp = new System.Windows.Forms.TextBox();
            this.txtSweepStartIp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNslookup = new System.Windows.Forms.Panel();
            this.btnNslookupRun = new System.Windows.Forms.Button();
            this.txtNslookupHost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsFileFinder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelFileFinder.SuspendLayout();
            this.panelPasswordHashUtility.SuspendLayout();
            this.grpAlgorithm.SuspendLayout();
            this.panelPortScanner.SuspendLayout();
            this.panelRemoteDesktop.SuspendLayout();
            this.panelLocalUsers.SuspendLayout();
            this.panelDiskManagement.SuspendLayout();
            this.panelDeviceManager.SuspendLayout();
            this.panelComputerManagement.SuspendLayout();
            this.panelServices.SuspendLayout();
            this.panelEventViewer.SuspendLayout();
            this.panelNetstat.SuspendLayout();
            this.panelArp.SuspendLayout();
            this.panelTcpPort.SuspendLayout();
            this.paneltracert.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.panelPing.SuspendLayout();
            this.panelPingSweep.SuspendLayout();
            this.panelNslookup.SuspendLayout();
            this.cmsFileFinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(467, 155);
            this.textBox1.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(3, 21);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(122, 19);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "8.8.8.8";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // chkContinuous
            // 
            this.chkContinuous.AutoSize = true;
            this.chkContinuous.Location = new System.Drawing.Point(2, 46);
            this.chkContinuous.Margin = new System.Windows.Forms.Padding(2);
            this.chkContinuous.Name = "chkContinuous";
            this.chkContinuous.Size = new System.Drawing.Size(66, 16);
            this.chkContinuous.TabIndex = 3;
            this.chkContinuous.Text = "継続(-t)";
            this.chkContinuous.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(2, 89);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host/IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRdp
            // 
            this.btnRdp.Location = new System.Drawing.Point(2, 116);
            this.btnRdp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRdp.Name = "btnRdp";
            this.btnRdp.Size = new System.Drawing.Size(71, 23);
            this.btnRdp.TabIndex = 6;
            this.btnRdp.Text = "RDP接続";
            this.btnRdp.UseVisualStyleBackColor = true;
            this.btnRdp.Click += new System.EventHandler(this.btnRdp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 299);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(469, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ネットワーク";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPingSweep);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRdp);
            this.panel1.Controls.Add(this.chkContinuous);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnNslookup);
            this.panel1.Controls.Add(this.btnTracert);
            this.panel1.Controls.Add(this.btnPortcktcp);
            this.panel1.Location = new System.Drawing.Point(11, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 328);
            this.panel1.TabIndex = 8;
            // 
            // btnPingSweep
            // 
            this.btnPingSweep.Location = new System.Drawing.Point(2, 60);
            this.btnPingSweep.Margin = new System.Windows.Forms.Padding(2);
            this.btnPingSweep.Name = "btnPingSweep";
            this.btnPingSweep.Size = new System.Drawing.Size(115, 23);
            this.btnPingSweep.TabIndex = 17;
            this.btnPingSweep.Text = "Ping Sweep";
            this.btnPingSweep.UseVisualStyleBackColor = true;
            this.btnPingSweep.Click += new System.EventHandler(this.btnPingSweep_Click);
            // 
            // btnNslookup
            // 
            this.btnNslookup.Location = new System.Drawing.Point(2, 143);
            this.btnNslookup.Margin = new System.Windows.Forms.Padding(2);
            this.btnNslookup.Name = "btnNslookup";
            this.btnNslookup.Size = new System.Drawing.Size(77, 23);
            this.btnNslookup.TabIndex = 7;
            this.btnNslookup.Text = "nslookup";
            this.btnNslookup.UseVisualStyleBackColor = true;
            this.btnNslookup.Click += new System.EventHandler(this.btnNslookup_Click);
            // 
            // btnTracert
            // 
            this.btnTracert.Location = new System.Drawing.Point(2, 171);
            this.btnTracert.Margin = new System.Windows.Forms.Padding(2);
            this.btnTracert.Name = "btnTracert";
            this.btnTracert.Size = new System.Drawing.Size(57, 23);
            this.btnTracert.TabIndex = 8;
            this.btnTracert.Text = "tracert";
            this.btnTracert.UseVisualStyleBackColor = true;
            this.btnTracert.Click += new System.EventHandler(this.btnTracert_Click);
            // 
            // btnPortcktcp
            // 
            this.btnPortcktcp.Location = new System.Drawing.Point(0, 198);
            this.btnPortcktcp.Margin = new System.Windows.Forms.Padding(2);
            this.btnPortcktcp.Name = "btnPortcktcp";
            this.btnPortcktcp.Size = new System.Drawing.Size(98, 23);
            this.btnPortcktcp.TabIndex = 9;
            this.btnPortcktcp.Text = "ポート確認(TCP)";
            this.btnPortcktcp.UseVisualStyleBackColor = true;
            this.btnPortcktcp.Click += new System.EventHandler(this.btnPortcktcp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtHost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPort);
            this.panel2.Controls.Add(this.txtStartIp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEndIp);
            this.panel2.Location = new System.Drawing.Point(159, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 202);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sweep to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sweep from";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(127, 21);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(62, 19);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "3389";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtStartIp
            // 
            this.txtStartIp.Location = new System.Drawing.Point(205, 21);
            this.txtStartIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartIp.Name = "txtStartIp";
            this.txtStartIp.Size = new System.Drawing.Size(122, 19);
            this.txtStartIp.TabIndex = 13;
            this.txtStartIp.Text = "192.168.2.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // txtEndIp
            // 
            this.txtEndIp.Location = new System.Drawing.Point(345, 21);
            this.txtEndIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndIp.Name = "txtEndIp";
            this.txtEndIp.Size = new System.Drawing.Size(122, 19);
            this.txtEndIp.TabIndex = 12;
            this.txtEndIp.Text = "192.168.2.254";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(469, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Windows";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(469, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "サーバ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelFileFinder);
            this.splitContainer1.Panel2.Controls.Add(this.panelPasswordHashUtility);
            this.splitContainer1.Panel2.Controls.Add(this.panelPortScanner);
            this.splitContainer1.Panel2.Controls.Add(this.panelRemoteDesktop);
            this.splitContainer1.Panel2.Controls.Add(this.panelLocalUsers);
            this.splitContainer1.Panel2.Controls.Add(this.panelDiskManagement);
            this.splitContainer1.Panel2.Controls.Add(this.panelDeviceManager);
            this.splitContainer1.Panel2.Controls.Add(this.panelComputerManagement);
            this.splitContainer1.Panel2.Controls.Add(this.panelServices);
            this.splitContainer1.Panel2.Controls.Add(this.panelEventViewer);
            this.splitContainer1.Panel2.Controls.Add(this.panelNetstat);
            this.splitContainer1.Panel2.Controls.Add(this.panelArp);
            this.splitContainer1.Panel2.Controls.Add(this.panelTcpPort);
            this.splitContainer1.Panel2.Controls.Add(this.paneltracert);
            this.splitContainer1.Panel2.Controls.Add(this.panelWork);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(707, 429);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 9);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "ping";
            treeNode1.Text = "Ping";
            treeNode2.Name = "pingSweep";
            treeNode2.Text = "Ping Sweep";
            treeNode3.Name = "nslookup";
            treeNode3.Text = "nslookup";
            treeNode4.Name = "tracert";
            treeNode4.Text = "tracert";
            treeNode5.Name = "tcpPort";
            treeNode5.Text = "TCP Port";
            treeNode6.Name = "arp";
            treeNode6.Text = "ARP";
            treeNode7.Name = "netstat";
            treeNode7.Text = "Netstat";
            treeNode8.Name = "network";
            treeNode8.Text = "Network";
            treeNode9.Name = "eventViewer";
            treeNode9.Text = "Event Viewer";
            treeNode10.Name = "services";
            treeNode10.Text = "Services";
            treeNode11.Name = "computerManagement";
            treeNode11.Text = "Computer Management";
            treeNode12.Name = "DeviceManager";
            treeNode12.Text = "Device Manager";
            treeNode13.Name = "DiskManagement";
            treeNode13.Text = "Disk Management";
            treeNode14.Name = "LocalUsers";
            treeNode14.Text = "Local Users";
            treeNode15.Name = "windows";
            treeNode15.Text = "Windows";
            treeNode16.Name = "RemoteDesktop";
            treeNode16.Text = "Remote Desktop";
            treeNode17.Name = "Remote";
            treeNode17.Text = "Remote";
            treeNode18.Name = "server";
            treeNode18.Text = "Server";
            treeNode19.Name = "PortScanner";
            treeNode19.Text = "Port Scanner";
            treeNode20.Name = "PasswordHashUtility";
            treeNode20.Text = "Password Hash Utility";
            treeNode21.Name = "FileFinder";
            treeNode21.Text = "File Finder";
            treeNode22.Name = "MineTool";
            treeNode22.Text = "Mine Tool";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode15,
            treeNode17,
            treeNode18,
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(128, 318);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelFileFinder
            // 
            this.panelFileFinder.Controls.Add(this.chkFileFinderEverything);
            this.panelFileFinder.Controls.Add(this.lblFileFinderStatus);
            this.panelFileFinder.Controls.Add(this.lstFileFinderResults);
            this.panelFileFinder.Controls.Add(this.txtFileFinderPattern);
            this.panelFileFinder.Controls.Add(this.lblFileFinderPattern);
            this.panelFileFinder.Controls.Add(this.btnFileFinderStop);
            this.panelFileFinder.Controls.Add(this.btnFileFinderRun);
            this.panelFileFinder.Controls.Add(this.txtFileFinderKeyword);
            this.panelFileFinder.Controls.Add(this.btnFileFinderBrowse);
            this.panelFileFinder.Controls.Add(this.lblFileFinderKeyword);
            this.panelFileFinder.Controls.Add(this.txtFileFinderPath);
            this.panelFileFinder.Controls.Add(this.lblFileFinderPath);
            this.panelFileFinder.Location = new System.Drawing.Point(7, 55);
            this.panelFileFinder.Margin = new System.Windows.Forms.Padding(2);
            this.panelFileFinder.Name = "panelFileFinder";
            this.panelFileFinder.Size = new System.Drawing.Size(561, 123);
            this.panelFileFinder.TabIndex = 18;
            // 
            // chkFileFinderEverything
            // 
            this.chkFileFinderEverything.AutoSize = true;
            this.chkFileFinderEverything.Location = new System.Drawing.Point(7, 77);
            this.chkFileFinderEverything.Margin = new System.Windows.Forms.Padding(2);
            this.chkFileFinderEverything.Name = "chkFileFinderEverything";
            this.chkFileFinderEverything.Size = new System.Drawing.Size(106, 16);
            this.chkFileFinderEverything.TabIndex = 11;
            this.chkFileFinderEverything.Text = "Everythingモード";
            this.chkFileFinderEverything.UseVisualStyleBackColor = true;
            // 
            // lblFileFinderStatus
            // 
            this.lblFileFinderStatus.AutoSize = true;
            this.lblFileFinderStatus.Location = new System.Drawing.Point(160, 104);
            this.lblFileFinderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileFinderStatus.Name = "lblFileFinderStatus";
            this.lblFileFinderStatus.Size = new System.Drawing.Size(99, 12);
            this.lblFileFinderStatus.TabIndex = 10;
            this.lblFileFinderStatus.Text = "結果: 0件 / 0.00秒";
            // 
            // lstFileFinderResults
            // 
            this.lstFileFinderResults.ContextMenuStrip = this.cmsFileFinder;
            this.lstFileFinderResults.FormattingEnabled = true;
            this.lstFileFinderResults.ItemHeight = 12;
            this.lstFileFinderResults.Location = new System.Drawing.Point(269, 6);
            this.lstFileFinderResults.Margin = new System.Windows.Forms.Padding(2);
            this.lstFileFinderResults.Name = "lstFileFinderResults";
            this.lstFileFinderResults.Size = new System.Drawing.Size(288, 112);
            this.lstFileFinderResults.TabIndex = 9;
            this.lstFileFinderResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFileFinderResults_MouseDown);
            // 
            // txtFileFinderPattern
            // 
            this.txtFileFinderPattern.Location = new System.Drawing.Point(68, 53);
            this.txtFileFinderPattern.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileFinderPattern.Name = "txtFileFinderPattern";
            this.txtFileFinderPattern.Size = new System.Drawing.Size(62, 19);
            this.txtFileFinderPattern.TabIndex = 8;
            this.txtFileFinderPattern.Text = "*.*";
            // 
            // lblFileFinderPattern
            // 
            this.lblFileFinderPattern.AutoSize = true;
            this.lblFileFinderPattern.Location = new System.Drawing.Point(4, 55);
            this.lblFileFinderPattern.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileFinderPattern.Name = "lblFileFinderPattern";
            this.lblFileFinderPattern.Size = new System.Drawing.Size(63, 12);
            this.lblFileFinderPattern.TabIndex = 7;
            this.lblFileFinderPattern.Text = "ファイル種類";
            // 
            // btnFileFinderStop
            // 
            this.btnFileFinderStop.Location = new System.Drawing.Point(205, 27);
            this.btnFileFinderStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileFinderStop.Name = "btnFileFinderStop";
            this.btnFileFinderStop.Size = new System.Drawing.Size(42, 20);
            this.btnFileFinderStop.TabIndex = 6;
            this.btnFileFinderStop.Text = "停止";
            this.btnFileFinderStop.UseVisualStyleBackColor = true;
            // 
            // btnFileFinderRun
            // 
            this.btnFileFinderRun.Location = new System.Drawing.Point(161, 27);
            this.btnFileFinderRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileFinderRun.Name = "btnFileFinderRun";
            this.btnFileFinderRun.Size = new System.Drawing.Size(42, 20);
            this.btnFileFinderRun.TabIndex = 5;
            this.btnFileFinderRun.Text = "検索";
            this.btnFileFinderRun.UseVisualStyleBackColor = true;
            // 
            // txtFileFinderKeyword
            // 
            this.txtFileFinderKeyword.Location = new System.Drawing.Point(68, 29);
            this.txtFileFinderKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileFinderKeyword.Name = "txtFileFinderKeyword";
            this.txtFileFinderKeyword.Size = new System.Drawing.Size(92, 19);
            this.txtFileFinderKeyword.TabIndex = 4;
            // 
            // btnFileFinderBrowse
            // 
            this.btnFileFinderBrowse.Location = new System.Drawing.Point(161, 3);
            this.btnFileFinderBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileFinderBrowse.Name = "btnFileFinderBrowse";
            this.btnFileFinderBrowse.Size = new System.Drawing.Size(86, 20);
            this.btnFileFinderBrowse.TabIndex = 3;
            this.btnFileFinderBrowse.Text = "参照";
            this.btnFileFinderBrowse.UseVisualStyleBackColor = true;
            // 
            // lblFileFinderKeyword
            // 
            this.lblFileFinderKeyword.AutoSize = true;
            this.lblFileFinderKeyword.Location = new System.Drawing.Point(4, 33);
            this.lblFileFinderKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileFinderKeyword.Name = "lblFileFinderKeyword";
            this.lblFileFinderKeyword.Size = new System.Drawing.Size(65, 12);
            this.lblFileFinderKeyword.TabIndex = 2;
            this.lblFileFinderKeyword.Text = "検索文字列";
            // 
            // txtFileFinderPath
            // 
            this.txtFileFinderPath.Location = new System.Drawing.Point(68, 5);
            this.txtFileFinderPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileFinderPath.Name = "txtFileFinderPath";
            this.txtFileFinderPath.Size = new System.Drawing.Size(92, 19);
            this.txtFileFinderPath.TabIndex = 1;
            // 
            // lblFileFinderPath
            // 
            this.lblFileFinderPath.AutoSize = true;
            this.lblFileFinderPath.Location = new System.Drawing.Point(4, 9);
            this.lblFileFinderPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileFinderPath.Name = "lblFileFinderPath";
            this.lblFileFinderPath.Size = new System.Drawing.Size(64, 12);
            this.lblFileFinderPath.TabIndex = 0;
            this.lblFileFinderPath.Text = "検索フォルダ";
            // 
            // panelPasswordHashUtility
            // 
            this.panelPasswordHashUtility.Controls.Add(this.btnCopyHash);
            this.panelPasswordHashUtility.Controls.Add(this.txtHash);
            this.panelPasswordHashUtility.Controls.Add(this.lblHash);
            this.panelPasswordHashUtility.Controls.Add(this.btnGenerateHash);
            this.panelPasswordHashUtility.Controls.Add(this.grpAlgorithm);
            this.panelPasswordHashUtility.Controls.Add(this.txtPassword);
            this.panelPasswordHashUtility.Controls.Add(this.lblPassword);
            this.panelPasswordHashUtility.Location = new System.Drawing.Point(6, 54);
            this.panelPasswordHashUtility.Margin = new System.Windows.Forms.Padding(2);
            this.panelPasswordHashUtility.Name = "panelPasswordHashUtility";
            this.panelPasswordHashUtility.Size = new System.Drawing.Size(561, 123);
            this.panelPasswordHashUtility.TabIndex = 17;
            // 
            // btnCopyHash
            // 
            this.btnCopyHash.Location = new System.Drawing.Point(451, 26);
            this.btnCopyHash.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyHash.Name = "btnCopyHash";
            this.btnCopyHash.Size = new System.Drawing.Size(86, 20);
            this.btnCopyHash.TabIndex = 12;
            this.btnCopyHash.Text = "コピー";
            this.btnCopyHash.UseVisualStyleBackColor = true;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(58, 28);
            this.txtHash.Margin = new System.Windows.Forms.Padding(2);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(392, 19);
            this.txtHash.TabIndex = 11;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(8, 29);
            this.lblHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(31, 12);
            this.lblHash.TabIndex = 10;
            this.lblHash.Text = "Hash";
            // 
            // btnGenerateHash
            // 
            this.btnGenerateHash.Location = new System.Drawing.Point(451, 4);
            this.btnGenerateHash.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateHash.Name = "btnGenerateHash";
            this.btnGenerateHash.Size = new System.Drawing.Size(86, 20);
            this.btnGenerateHash.TabIndex = 9;
            this.btnGenerateHash.Text = "ハッシュ値生成";
            this.btnGenerateHash.UseVisualStyleBackColor = true;
            this.btnGenerateHash.Click += new System.EventHandler(this.btnGenerateHash_Click);
            // 
            // grpAlgorithm
            // 
            this.grpAlgorithm.Controls.Add(this.rdoMD5);
            this.grpAlgorithm.Controls.Add(this.rdoSHA1);
            this.grpAlgorithm.Controls.Add(this.rdoSHA256);
            this.grpAlgorithm.Controls.Add(this.rdoSHA384);
            this.grpAlgorithm.Controls.Add(this.rdoSHA512);
            this.grpAlgorithm.Location = new System.Drawing.Point(4, 52);
            this.grpAlgorithm.Margin = new System.Windows.Forms.Padding(2);
            this.grpAlgorithm.Name = "grpAlgorithm";
            this.grpAlgorithm.Padding = new System.Windows.Forms.Padding(2);
            this.grpAlgorithm.Size = new System.Drawing.Size(293, 67);
            this.grpAlgorithm.TabIndex = 3;
            this.grpAlgorithm.TabStop = false;
            this.grpAlgorithm.Text = "Algorithm";
            // 
            // rdoMD5
            // 
            this.rdoMD5.AutoSize = true;
            this.rdoMD5.Location = new System.Drawing.Point(5, 21);
            this.rdoMD5.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMD5.Name = "rdoMD5";
            this.rdoMD5.Size = new System.Drawing.Size(46, 16);
            this.rdoMD5.TabIndex = 4;
            this.rdoMD5.TabStop = true;
            this.rdoMD5.Text = "MD5";
            this.rdoMD5.UseVisualStyleBackColor = true;
            // 
            // rdoSHA1
            // 
            this.rdoSHA1.AutoSize = true;
            this.rdoSHA1.Location = new System.Drawing.Point(5, 42);
            this.rdoSHA1.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSHA1.Name = "rdoSHA1";
            this.rdoSHA1.Size = new System.Drawing.Size(52, 16);
            this.rdoSHA1.TabIndex = 5;
            this.rdoSHA1.TabStop = true;
            this.rdoSHA1.Text = "SHA1";
            this.rdoSHA1.UseVisualStyleBackColor = true;
            // 
            // rdoSHA256
            // 
            this.rdoSHA256.AutoSize = true;
            this.rdoSHA256.Location = new System.Drawing.Point(59, 42);
            this.rdoSHA256.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSHA256.Name = "rdoSHA256";
            this.rdoSHA256.Size = new System.Drawing.Size(64, 16);
            this.rdoSHA256.TabIndex = 6;
            this.rdoSHA256.TabStop = true;
            this.rdoSHA256.Text = "SHA256";
            this.rdoSHA256.UseVisualStyleBackColor = true;
            // 
            // rdoSHA384
            // 
            this.rdoSHA384.AutoSize = true;
            this.rdoSHA384.Location = new System.Drawing.Point(135, 42);
            this.rdoSHA384.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSHA384.Name = "rdoSHA384";
            this.rdoSHA384.Size = new System.Drawing.Size(64, 16);
            this.rdoSHA384.TabIndex = 7;
            this.rdoSHA384.TabStop = true;
            this.rdoSHA384.Text = "SHA384";
            this.rdoSHA384.UseVisualStyleBackColor = true;
            // 
            // rdoSHA512
            // 
            this.rdoSHA512.AutoSize = true;
            this.rdoSHA512.Location = new System.Drawing.Point(208, 42);
            this.rdoSHA512.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSHA512.Name = "rdoSHA512";
            this.rdoSHA512.Size = new System.Drawing.Size(64, 16);
            this.rdoSHA512.TabIndex = 8;
            this.rdoSHA512.TabStop = true;
            this.rdoSHA512.Text = "SHA512";
            this.rdoSHA512.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(58, 6);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(392, 19);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 8);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // panelPortScanner
            // 
            this.panelPortScanner.Controls.Add(this.btnPortScannerStop);
            this.panelPortScanner.Controls.Add(this.btnPortScannerRun);
            this.panelPortScanner.Controls.Add(this.txtPortScannerEndPort);
            this.panelPortScanner.Controls.Add(this.txtPortScannerStartPort);
            this.panelPortScanner.Controls.Add(this.label29);
            this.panelPortScanner.Controls.Add(this.label28);
            this.panelPortScanner.Controls.Add(this.txtPortScannerHost);
            this.panelPortScanner.Controls.Add(this.label27);
            this.panelPortScanner.Controls.Add(this.label26);
            this.panelPortScanner.Location = new System.Drawing.Point(6, 53);
            this.panelPortScanner.Margin = new System.Windows.Forms.Padding(2);
            this.panelPortScanner.Name = "panelPortScanner";
            this.panelPortScanner.Size = new System.Drawing.Size(561, 123);
            this.panelPortScanner.TabIndex = 16;
            // 
            // btnPortScannerStop
            // 
            this.btnPortScannerStop.Location = new System.Drawing.Point(105, 99);
            this.btnPortScannerStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnPortScannerStop.Name = "btnPortScannerStop";
            this.btnPortScannerStop.Size = new System.Drawing.Size(90, 20);
            this.btnPortScannerStop.TabIndex = 8;
            this.btnPortScannerStop.Text = "停止";
            this.btnPortScannerStop.UseVisualStyleBackColor = true;
            // 
            // btnPortScannerRun
            // 
            this.btnPortScannerRun.Location = new System.Drawing.Point(11, 99);
            this.btnPortScannerRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnPortScannerRun.Name = "btnPortScannerRun";
            this.btnPortScannerRun.Size = new System.Drawing.Size(90, 20);
            this.btnPortScannerRun.TabIndex = 7;
            this.btnPortScannerRun.Text = "スキャン開始";
            this.btnPortScannerRun.UseVisualStyleBackColor = true;
            // 
            // txtPortScannerEndPort
            // 
            this.txtPortScannerEndPort.Location = new System.Drawing.Point(123, 73);
            this.txtPortScannerEndPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortScannerEndPort.Name = "txtPortScannerEndPort";
            this.txtPortScannerEndPort.Size = new System.Drawing.Size(110, 19);
            this.txtPortScannerEndPort.TabIndex = 6;
            this.txtPortScannerEndPort.Text = "1024";
            // 
            // txtPortScannerStartPort
            // 
            this.txtPortScannerStartPort.Location = new System.Drawing.Point(11, 73);
            this.txtPortScannerStartPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortScannerStartPort.Name = "txtPortScannerStartPort";
            this.txtPortScannerStartPort.Size = new System.Drawing.Size(110, 19);
            this.txtPortScannerStartPort.TabIndex = 5;
            this.txtPortScannerStartPort.Text = "1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 59);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 12);
            this.label29.TabIndex = 4;
            this.label29.Text = "開始ポート";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(121, 58);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 12);
            this.label28.TabIndex = 3;
            this.label28.Text = "終了ポート";
            // 
            // txtPortScannerHost
            // 
            this.txtPortScannerHost.Location = new System.Drawing.Point(10, 38);
            this.txtPortScannerHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortScannerHost.Name = "txtPortScannerHost";
            this.txtPortScannerHost.Size = new System.Drawing.Size(110, 19);
            this.txtPortScannerHost.TabIndex = 2;
            this.txtPortScannerHost.Text = "192.168.1.1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 24);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 12);
            this.label27.TabIndex = 1;
            this.label27.Text = "Host/IP";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 7);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "Port Scanner";
            // 
            // panelRemoteDesktop
            // 
            this.panelRemoteDesktop.Controls.Add(this.btnRemoteDesktopRun);
            this.panelRemoteDesktop.Controls.Add(this.txtRemoteDesktopHost);
            this.panelRemoteDesktop.Controls.Add(this.label25);
            this.panelRemoteDesktop.Controls.Add(this.label24);
            this.panelRemoteDesktop.Location = new System.Drawing.Point(7, 53);
            this.panelRemoteDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelRemoteDesktop.Name = "panelRemoteDesktop";
            this.panelRemoteDesktop.Size = new System.Drawing.Size(561, 123);
            this.panelRemoteDesktop.TabIndex = 15;
            // 
            // btnRemoteDesktopRun
            // 
            this.btnRemoteDesktopRun.Location = new System.Drawing.Point(9, 78);
            this.btnRemoteDesktopRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoteDesktopRun.Name = "btnRemoteDesktopRun";
            this.btnRemoteDesktopRun.Size = new System.Drawing.Size(90, 20);
            this.btnRemoteDesktopRun.TabIndex = 3;
            this.btnRemoteDesktopRun.Text = "RDP接続";
            this.btnRemoteDesktopRun.UseVisualStyleBackColor = true;
            this.btnRemoteDesktopRun.Click += new System.EventHandler(this.btnRemoteDesktopRun_Click);
            // 
            // txtRemoteDesktopHost
            // 
            this.txtRemoteDesktopHost.Location = new System.Drawing.Point(9, 50);
            this.txtRemoteDesktopHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteDesktopHost.Name = "txtRemoteDesktopHost";
            this.txtRemoteDesktopHost.Size = new System.Drawing.Size(110, 19);
            this.txtRemoteDesktopHost.TabIndex = 2;
            this.txtRemoteDesktopHost.Text = "192.168.1.1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 32);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "接続先";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 7);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "Remote Desktop";
            // 
            // panelLocalUsers
            // 
            this.panelLocalUsers.Controls.Add(this.btnLocalUsersRun);
            this.panelLocalUsers.Controls.Add(this.label23);
            this.panelLocalUsers.Location = new System.Drawing.Point(6, 55);
            this.panelLocalUsers.Margin = new System.Windows.Forms.Padding(2);
            this.panelLocalUsers.Name = "panelLocalUsers";
            this.panelLocalUsers.Size = new System.Drawing.Size(561, 123);
            this.panelLocalUsers.TabIndex = 14;
            // 
            // btnLocalUsersRun
            // 
            this.btnLocalUsersRun.Location = new System.Drawing.Point(10, 26);
            this.btnLocalUsersRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalUsersRun.Name = "btnLocalUsersRun";
            this.btnLocalUsersRun.Size = new System.Drawing.Size(180, 20);
            this.btnLocalUsersRun.TabIndex = 1;
            this.btnLocalUsersRun.Text = "ローカルユーザーとグループを開く";
            this.btnLocalUsersRun.UseVisualStyleBackColor = true;
            this.btnLocalUsersRun.Click += new System.EventHandler(this.btnLocalUsersRun_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "Local Users";
            // 
            // panelDiskManagement
            // 
            this.panelDiskManagement.Controls.Add(this.btnDiskManagementRun);
            this.panelDiskManagement.Controls.Add(this.label22);
            this.panelDiskManagement.Location = new System.Drawing.Point(7, 55);
            this.panelDiskManagement.Margin = new System.Windows.Forms.Padding(2);
            this.panelDiskManagement.Name = "panelDiskManagement";
            this.panelDiskManagement.Size = new System.Drawing.Size(561, 123);
            this.panelDiskManagement.TabIndex = 13;
            // 
            // btnDiskManagementRun
            // 
            this.btnDiskManagementRun.Location = new System.Drawing.Point(8, 26);
            this.btnDiskManagementRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiskManagementRun.Name = "btnDiskManagementRun";
            this.btnDiskManagementRun.Size = new System.Drawing.Size(136, 20);
            this.btnDiskManagementRun.TabIndex = 1;
            this.btnDiskManagementRun.Text = "ディスクの管理を開く";
            this.btnDiskManagementRun.UseVisualStyleBackColor = true;
            this.btnDiskManagementRun.Click += new System.EventHandler(this.btnDiskManagementRun_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 7);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "Disk Management";
            // 
            // panelDeviceManager
            // 
            this.panelDeviceManager.Controls.Add(this.btnDeviceManagerRun);
            this.panelDeviceManager.Controls.Add(this.label21);
            this.panelDeviceManager.Location = new System.Drawing.Point(6, 55);
            this.panelDeviceManager.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeviceManager.Name = "panelDeviceManager";
            this.panelDeviceManager.Size = new System.Drawing.Size(561, 123);
            this.panelDeviceManager.TabIndex = 12;
            // 
            // btnDeviceManagerRun
            // 
            this.btnDeviceManagerRun.Location = new System.Drawing.Point(8, 23);
            this.btnDeviceManagerRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeviceManagerRun.Name = "btnDeviceManagerRun";
            this.btnDeviceManagerRun.Size = new System.Drawing.Size(136, 20);
            this.btnDeviceManagerRun.TabIndex = 1;
            this.btnDeviceManagerRun.Text = "デバイスマネージャーを開く";
            this.btnDeviceManagerRun.UseVisualStyleBackColor = true;
            this.btnDeviceManagerRun.Click += new System.EventHandler(this.btnDeviceManagerRun_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 6);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "DeviceManager";
            // 
            // panelComputerManagement
            // 
            this.panelComputerManagement.Controls.Add(this.label20);
            this.panelComputerManagement.Controls.Add(this.btnComputerManagementRun);
            this.panelComputerManagement.Location = new System.Drawing.Point(6, 55);
            this.panelComputerManagement.Margin = new System.Windows.Forms.Padding(2);
            this.panelComputerManagement.Name = "panelComputerManagement";
            this.panelComputerManagement.Size = new System.Drawing.Size(561, 123);
            this.panelComputerManagement.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "ComputerManagement";
            // 
            // btnComputerManagementRun
            // 
            this.btnComputerManagementRun.Location = new System.Drawing.Point(8, 25);
            this.btnComputerManagementRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnComputerManagementRun.Name = "btnComputerManagementRun";
            this.btnComputerManagementRun.Size = new System.Drawing.Size(136, 20);
            this.btnComputerManagementRun.TabIndex = 0;
            this.btnComputerManagementRun.Text = "コンピューターの管理を開く";
            this.btnComputerManagementRun.UseVisualStyleBackColor = true;
            this.btnComputerManagementRun.Click += new System.EventHandler(this.btnComputerManagementRun_Click);
            // 
            // panelServices
            // 
            this.panelServices.Controls.Add(this.btnServicesRun);
            this.panelServices.Controls.Add(this.label19);
            this.panelServices.Location = new System.Drawing.Point(6, 53);
            this.panelServices.Margin = new System.Windows.Forms.Padding(2);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(561, 123);
            this.panelServices.TabIndex = 10;
            // 
            // btnServicesRun
            // 
            this.btnServicesRun.Location = new System.Drawing.Point(8, 27);
            this.btnServicesRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnServicesRun.Name = "btnServicesRun";
            this.btnServicesRun.Size = new System.Drawing.Size(120, 20);
            this.btnServicesRun.TabIndex = 1;
            this.btnServicesRun.Text = "サービスを開く";
            this.btnServicesRun.UseVisualStyleBackColor = true;
            this.btnServicesRun.Click += new System.EventHandler(this.btnServicesRun_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 8);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "Services";
            // 
            // panelEventViewer
            // 
            this.panelEventViewer.Controls.Add(this.btnEventViewerSecurity);
            this.panelEventViewer.Controls.Add(this.btnEventViewerApplication);
            this.panelEventViewer.Controls.Add(this.btnEventViewerSystem);
            this.panelEventViewer.Controls.Add(this.btnEventViewerRun);
            this.panelEventViewer.Controls.Add(this.label18);
            this.panelEventViewer.Location = new System.Drawing.Point(6, 55);
            this.panelEventViewer.Margin = new System.Windows.Forms.Padding(2);
            this.panelEventViewer.Name = "panelEventViewer";
            this.panelEventViewer.Size = new System.Drawing.Size(561, 123);
            this.panelEventViewer.TabIndex = 9;
            // 
            // btnEventViewerSecurity
            // 
            this.btnEventViewerSecurity.Location = new System.Drawing.Point(8, 101);
            this.btnEventViewerSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventViewerSecurity.Name = "btnEventViewerSecurity";
            this.btnEventViewerSecurity.Size = new System.Drawing.Size(120, 20);
            this.btnEventViewerSecurity.TabIndex = 4;
            this.btnEventViewerSecurity.Text = "Securityログ";
            this.btnEventViewerSecurity.UseVisualStyleBackColor = true;
            this.btnEventViewerSecurity.Click += new System.EventHandler(this.btnEventViewerSecurity_Click);
            // 
            // btnEventViewerApplication
            // 
            this.btnEventViewerApplication.Location = new System.Drawing.Point(9, 77);
            this.btnEventViewerApplication.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventViewerApplication.Name = "btnEventViewerApplication";
            this.btnEventViewerApplication.Size = new System.Drawing.Size(120, 20);
            this.btnEventViewerApplication.TabIndex = 3;
            this.btnEventViewerApplication.Text = "Applicationログ";
            this.btnEventViewerApplication.UseVisualStyleBackColor = true;
            this.btnEventViewerApplication.Click += new System.EventHandler(this.btnEventViewerApplication_Click);
            // 
            // btnEventViewerSystem
            // 
            this.btnEventViewerSystem.Location = new System.Drawing.Point(9, 53);
            this.btnEventViewerSystem.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventViewerSystem.Name = "btnEventViewerSystem";
            this.btnEventViewerSystem.Size = new System.Drawing.Size(120, 20);
            this.btnEventViewerSystem.TabIndex = 2;
            this.btnEventViewerSystem.Text = "Systemログ";
            this.btnEventViewerSystem.UseVisualStyleBackColor = true;
            this.btnEventViewerSystem.Click += new System.EventHandler(this.btnEventViewerSystem_Click);
            // 
            // btnEventViewerRun
            // 
            this.btnEventViewerRun.Location = new System.Drawing.Point(8, 29);
            this.btnEventViewerRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventViewerRun.Name = "btnEventViewerRun";
            this.btnEventViewerRun.Size = new System.Drawing.Size(120, 20);
            this.btnEventViewerRun.TabIndex = 1;
            this.btnEventViewerRun.Text = "イベントビューア";
            this.btnEventViewerRun.UseVisualStyleBackColor = true;
            this.btnEventViewerRun.Click += new System.EventHandler(this.btnEventViewerRun_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "Event Viewer";
            // 
            // panelNetstat
            // 
            this.panelNetstat.Controls.Add(this.btnNetstatStop);
            this.panelNetstat.Controls.Add(this.btnNetstatRun);
            this.panelNetstat.Controls.Add(this.chkNetstatNumeric);
            this.panelNetstat.Controls.Add(this.chkNetstatAll);
            this.panelNetstat.Controls.Add(this.label17);
            this.panelNetstat.Location = new System.Drawing.Point(7, 54);
            this.panelNetstat.Margin = new System.Windows.Forms.Padding(2);
            this.panelNetstat.Name = "panelNetstat";
            this.panelNetstat.Size = new System.Drawing.Size(561, 123);
            this.panelNetstat.TabIndex = 7;
            // 
            // btnNetstatStop
            // 
            this.btnNetstatStop.Location = new System.Drawing.Point(72, 85);
            this.btnNetstatStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnNetstatStop.Name = "btnNetstatStop";
            this.btnNetstatStop.Size = new System.Drawing.Size(60, 20);
            this.btnNetstatStop.TabIndex = 4;
            this.btnNetstatStop.Text = "停止";
            this.btnNetstatStop.UseVisualStyleBackColor = true;
            this.btnNetstatStop.Click += new System.EventHandler(this.btnNetstatStop_Click);
            // 
            // btnNetstatRun
            // 
            this.btnNetstatRun.Location = new System.Drawing.Point(8, 85);
            this.btnNetstatRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnNetstatRun.Name = "btnNetstatRun";
            this.btnNetstatRun.Size = new System.Drawing.Size(60, 20);
            this.btnNetstatRun.TabIndex = 3;
            this.btnNetstatRun.Text = "実行";
            this.btnNetstatRun.UseVisualStyleBackColor = true;
            this.btnNetstatRun.Click += new System.EventHandler(this.btnNetstatRun_Click);
            // 
            // chkNetstatNumeric
            // 
            this.chkNetstatNumeric.AutoSize = true;
            this.chkNetstatNumeric.Checked = true;
            this.chkNetstatNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetstatNumeric.Location = new System.Drawing.Point(8, 55);
            this.chkNetstatNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.chkNetstatNumeric.Name = "chkNetstatNumeric";
            this.chkNetstatNumeric.Size = new System.Drawing.Size(121, 16);
            this.chkNetstatNumeric.TabIndex = 2;
            this.chkNetstatNumeric.Text = "名前解決しない(-n)";
            this.chkNetstatNumeric.UseVisualStyleBackColor = true;
            // 
            // chkNetstatAll
            // 
            this.chkNetstatAll.AutoSize = true;
            this.chkNetstatAll.Checked = true;
            this.chkNetstatAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetstatAll.Location = new System.Drawing.Point(8, 27);
            this.chkNetstatAll.Margin = new System.Windows.Forms.Padding(2);
            this.chkNetstatAll.Name = "chkNetstatAll";
            this.chkNetstatAll.Size = new System.Drawing.Size(97, 16);
            this.chkNetstatAll.TabIndex = 1;
            this.chkNetstatAll.Text = "すべて表示(-a)";
            this.chkNetstatAll.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 8);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "Netstat";
            // 
            // panelArp
            // 
            this.panelArp.Controls.Add(this.btnArpRun);
            this.panelArp.Controls.Add(this.txtArpHost);
            this.panelArp.Controls.Add(this.label16);
            this.panelArp.Controls.Add(this.label15);
            this.panelArp.Location = new System.Drawing.Point(7, 55);
            this.panelArp.Margin = new System.Windows.Forms.Padding(2);
            this.panelArp.Name = "panelArp";
            this.panelArp.Size = new System.Drawing.Size(561, 123);
            this.panelArp.TabIndex = 6;
            // 
            // btnArpRun
            // 
            this.btnArpRun.Location = new System.Drawing.Point(5, 56);
            this.btnArpRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnArpRun.Name = "btnArpRun";
            this.btnArpRun.Size = new System.Drawing.Size(60, 20);
            this.btnArpRun.TabIndex = 3;
            this.btnArpRun.Text = "実行";
            this.btnArpRun.UseVisualStyleBackColor = true;
            this.btnArpRun.Click += new System.EventHandler(this.btnArpRun_Click);
            // 
            // txtArpHost
            // 
            this.txtArpHost.Location = new System.Drawing.Point(4, 35);
            this.txtArpHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtArpHost.Name = "txtArpHost";
            this.txtArpHost.Size = new System.Drawing.Size(110, 19);
            this.txtArpHost.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "Host/IP(空欄なら全表示)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "ARP";
            // 
            // panelTcpPort
            // 
            this.panelTcpPort.Controls.Add(this.btnTcpPortRun);
            this.panelTcpPort.Controls.Add(this.label14);
            this.panelTcpPort.Controls.Add(this.txtTcpPort);
            this.panelTcpPort.Controls.Add(this.txtTcpHost);
            this.panelTcpPort.Controls.Add(this.label13);
            this.panelTcpPort.Controls.Add(this.label12);
            this.panelTcpPort.Location = new System.Drawing.Point(4, 53);
            this.panelTcpPort.Margin = new System.Windows.Forms.Padding(2);
            this.panelTcpPort.Name = "panelTcpPort";
            this.panelTcpPort.Size = new System.Drawing.Size(564, 121);
            this.panelTcpPort.TabIndex = 5;
            // 
            // btnTcpPortRun
            // 
            this.btnTcpPortRun.Location = new System.Drawing.Point(8, 98);
            this.btnTcpPortRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnTcpPortRun.Name = "btnTcpPortRun";
            this.btnTcpPortRun.Size = new System.Drawing.Size(60, 20);
            this.btnTcpPortRun.TabIndex = 5;
            this.btnTcpPortRun.Text = "Scan";
            this.btnTcpPortRun.UseVisualStyleBackColor = true;
            this.btnTcpPortRun.Click += new System.EventHandler(this.btnTcpPortRun_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "Port（空欄なら主要ポート）";
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(8, 78);
            this.txtTcpPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(110, 19);
            this.txtTcpPort.TabIndex = 3;
            // 
            // txtTcpHost
            // 
            this.txtTcpHost.Location = new System.Drawing.Point(8, 36);
            this.txtTcpHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcpHost.Name = "txtTcpHost";
            this.txtTcpHost.Size = new System.Drawing.Size(110, 19);
            this.txtTcpHost.TabIndex = 2;
            this.txtTcpHost.Text = "8.8.8.8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "Host/IP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "TCP Port";
            // 
            // paneltracert
            // 
            this.paneltracert.Controls.Add(this.btnTracertStop);
            this.paneltracert.Controls.Add(this.btnTracertRun);
            this.paneltracert.Controls.Add(this.txtTracertHost);
            this.paneltracert.Controls.Add(this.label11);
            this.paneltracert.Controls.Add(this.label10);
            this.paneltracert.Location = new System.Drawing.Point(4, 53);
            this.paneltracert.Margin = new System.Windows.Forms.Padding(2);
            this.paneltracert.Name = "paneltracert";
            this.paneltracert.Size = new System.Drawing.Size(566, 123);
            this.paneltracert.TabIndex = 4;
            // 
            // btnTracertStop
            // 
            this.btnTracertStop.Location = new System.Drawing.Point(70, 71);
            this.btnTracertStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnTracertStop.Name = "btnTracertStop";
            this.btnTracertStop.Size = new System.Drawing.Size(60, 20);
            this.btnTracertStop.TabIndex = 4;
            this.btnTracertStop.Text = "停止";
            this.btnTracertStop.UseVisualStyleBackColor = true;
            // 
            // btnTracertRun
            // 
            this.btnTracertRun.Location = new System.Drawing.Point(7, 71);
            this.btnTracertRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnTracertRun.Name = "btnTracertRun";
            this.btnTracertRun.Size = new System.Drawing.Size(60, 20);
            this.btnTracertRun.TabIndex = 3;
            this.btnTracertRun.Text = "tracert";
            this.btnTracertRun.UseVisualStyleBackColor = true;
            // 
            // txtTracertHost
            // 
            this.txtTracertHost.Location = new System.Drawing.Point(7, 42);
            this.txtTracertHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTracertHost.Name = "txtTracertHost";
            this.txtTracertHost.Size = new System.Drawing.Size(110, 19);
            this.txtTracertHost.TabIndex = 2;
            this.txtTracertHost.Text = "192.168.1.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Host/IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "tracert";
            // 
            // panelWork
            // 
            this.panelWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWork.Controls.Add(this.panelPing);
            this.panelWork.Controls.Add(this.panelPingSweep);
            this.panelWork.Controls.Add(this.panelNslookup);
            this.panelWork.Controls.Add(this.panelHome);
            this.panelWork.Location = new System.Drawing.Point(2, 50);
            this.panelWork.Margin = new System.Windows.Forms.Padding(2);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(572, 129);
            this.panelWork.TabIndex = 1;
            // 
            // panelPing
            // 
            this.panelPing.Controls.Add(this.btnPingStop);
            this.panelPing.Controls.Add(this.chkPingContinuous);
            this.panelPing.Controls.Add(this.lblPingTitle);
            this.panelPing.Controls.Add(this.btnPingRun);
            this.panelPing.Controls.Add(this.txtPingHost);
            this.panelPing.Location = new System.Drawing.Point(2, 2);
            this.panelPing.Margin = new System.Windows.Forms.Padding(2);
            this.panelPing.Name = "panelPing";
            this.panelPing.Size = new System.Drawing.Size(563, 123);
            this.panelPing.TabIndex = 8;
            // 
            // btnPingStop
            // 
            this.btnPingStop.Location = new System.Drawing.Point(74, 67);
            this.btnPingStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnPingStop.Name = "btnPingStop";
            this.btnPingStop.Size = new System.Drawing.Size(60, 20);
            this.btnPingStop.TabIndex = 5;
            this.btnPingStop.Text = "停止";
            this.btnPingStop.UseVisualStyleBackColor = true;
            // 
            // chkPingContinuous
            // 
            this.chkPingContinuous.AutoSize = true;
            this.chkPingContinuous.Location = new System.Drawing.Point(10, 48);
            this.chkPingContinuous.Margin = new System.Windows.Forms.Padding(2);
            this.chkPingContinuous.Name = "chkPingContinuous";
            this.chkPingContinuous.Size = new System.Drawing.Size(90, 16);
            this.chkPingContinuous.TabIndex = 4;
            this.chkPingContinuous.Text = "継続実行(-t)";
            this.chkPingContinuous.UseVisualStyleBackColor = true;
            // 
            // lblPingTitle
            // 
            this.lblPingTitle.AutoSize = true;
            this.lblPingTitle.Location = new System.Drawing.Point(8, 7);
            this.lblPingTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPingTitle.Name = "lblPingTitle";
            this.lblPingTitle.Size = new System.Drawing.Size(27, 12);
            this.lblPingTitle.TabIndex = 0;
            this.lblPingTitle.Text = "Ping";
            // 
            // btnPingRun
            // 
            this.btnPingRun.Location = new System.Drawing.Point(10, 67);
            this.btnPingRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnPingRun.Name = "btnPingRun";
            this.btnPingRun.Size = new System.Drawing.Size(60, 20);
            this.btnPingRun.TabIndex = 2;
            this.btnPingRun.Text = "Ping";
            this.btnPingRun.UseVisualStyleBackColor = true;
            // 
            // txtPingHost
            // 
            this.txtPingHost.Location = new System.Drawing.Point(10, 23);
            this.txtPingHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtPingHost.Name = "txtPingHost";
            this.txtPingHost.Size = new System.Drawing.Size(110, 19);
            this.txtPingHost.TabIndex = 1;
            this.txtPingHost.Text = "8.8.8.8";
            // 
            // panelPingSweep
            // 
            this.panelPingSweep.Controls.Add(this.lblPingSweep);
            this.panelPingSweep.Controls.Add(this.btnPingSweepStop);
            this.panelPingSweep.Controls.Add(this.btnPingSweepRun);
            this.panelPingSweep.Controls.Add(this.txtSweepEndIp);
            this.panelPingSweep.Controls.Add(this.txtSweepStartIp);
            this.panelPingSweep.Controls.Add(this.label7);
            this.panelPingSweep.Controls.Add(this.label6);
            this.panelPingSweep.Location = new System.Drawing.Point(2, 2);
            this.panelPingSweep.Margin = new System.Windows.Forms.Padding(2);
            this.panelPingSweep.Name = "panelPingSweep";
            this.panelPingSweep.Size = new System.Drawing.Size(563, 123);
            this.panelPingSweep.TabIndex = 9;
            // 
            // lblPingSweep
            // 
            this.lblPingSweep.AutoSize = true;
            this.lblPingSweep.Location = new System.Drawing.Point(8, 7);
            this.lblPingSweep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPingSweep.Name = "lblPingSweep";
            this.lblPingSweep.Size = new System.Drawing.Size(64, 12);
            this.lblPingSweep.TabIndex = 6;
            this.lblPingSweep.Text = "Ping Sweep";
            // 
            // btnPingSweepStop
            // 
            this.btnPingSweepStop.Location = new System.Drawing.Point(90, 67);
            this.btnPingSweepStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnPingSweepStop.Name = "btnPingSweepStop";
            this.btnPingSweepStop.Size = new System.Drawing.Size(60, 20);
            this.btnPingSweepStop.TabIndex = 5;
            this.btnPingSweepStop.Text = "停止";
            this.btnPingSweepStop.UseVisualStyleBackColor = true;
            // 
            // btnPingSweepRun
            // 
            this.btnPingSweepRun.Location = new System.Drawing.Point(10, 67);
            this.btnPingSweepRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnPingSweepRun.Name = "btnPingSweepRun";
            this.btnPingSweepRun.Size = new System.Drawing.Size(76, 20);
            this.btnPingSweepRun.TabIndex = 4;
            this.btnPingSweepRun.Text = "スキャン開始";
            this.btnPingSweepRun.UseVisualStyleBackColor = true;
            // 
            // txtSweepEndIp
            // 
            this.txtSweepEndIp.Location = new System.Drawing.Point(122, 41);
            this.txtSweepEndIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSweepEndIp.Name = "txtSweepEndIp";
            this.txtSweepEndIp.Size = new System.Drawing.Size(110, 19);
            this.txtSweepEndIp.TabIndex = 3;
            this.txtSweepEndIp.Text = "192.168.1.254";
            // 
            // txtSweepStartIp
            // 
            this.txtSweepStartIp.Location = new System.Drawing.Point(10, 41);
            this.txtSweepStartIp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSweepStartIp.Name = "txtSweepStartIp";
            this.txtSweepStartIp.Size = new System.Drawing.Size(110, 19);
            this.txtSweepStartIp.TabIndex = 2;
            this.txtSweepStartIp.Text = "192.168.1.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "終了IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "開始IP";
            // 
            // panelNslookup
            // 
            this.panelNslookup.Controls.Add(this.btnNslookupRun);
            this.panelNslookup.Controls.Add(this.txtNslookupHost);
            this.panelNslookup.Controls.Add(this.label9);
            this.panelNslookup.Controls.Add(this.label8);
            this.panelNslookup.Location = new System.Drawing.Point(2, 2);
            this.panelNslookup.Margin = new System.Windows.Forms.Padding(2);
            this.panelNslookup.Name = "panelNslookup";
            this.panelNslookup.Size = new System.Drawing.Size(563, 123);
            this.panelNslookup.TabIndex = 10;
            // 
            // btnNslookupRun
            // 
            this.btnNslookupRun.Location = new System.Drawing.Point(8, 64);
            this.btnNslookupRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnNslookupRun.Name = "btnNslookupRun";
            this.btnNslookupRun.Size = new System.Drawing.Size(76, 20);
            this.btnNslookupRun.TabIndex = 3;
            this.btnNslookupRun.Text = "nslookup";
            this.btnNslookupRun.UseVisualStyleBackColor = true;
            // 
            // txtNslookupHost
            // 
            this.txtNslookupHost.Location = new System.Drawing.Point(8, 41);
            this.txtNslookupHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtNslookupHost.Name = "txtNslookupHost";
            this.txtNslookupHost.Size = new System.Drawing.Size(110, 19);
            this.txtNslookupHost.TabIndex = 2;
            this.txtNslookupHost.Text = "8.8.8.8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Host/IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "nslookup";
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(2, 2);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(563, 123);
            this.panelHome.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(14, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ここに画面タイトル";
            // 
            // cmsFileFinder
            // 
            this.cmsFileFinder.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsFileFinder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiOpenFolder,
            this.tsmiCopyPath});
            this.cmsFileFinder.Name = "cmsFileFinder";
            this.cmsFileFinder.Size = new System.Drawing.Size(138, 70);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(137, 22);
            this.tsmiOpen.Text = "開く";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiOpenFolder
            // 
            this.tsmiOpenFolder.Name = "tsmiOpenFolder";
            this.tsmiOpenFolder.Size = new System.Drawing.Size(137, 22);
            this.tsmiOpenFolder.Text = "フォルダを開く";
            this.tsmiOpenFolder.Click += new System.EventHandler(this.tsmiOpenFolder_Click);
            // 
            // tsmiCopyPath
            // 
            this.tsmiCopyPath.Name = "tsmiCopyPath";
            this.tsmiCopyPath.Size = new System.Drawing.Size(137, 22);
            this.tsmiCopyPath.Text = "パスをコピー";
            this.tsmiCopyPath.Click += new System.EventHandler(this.tsmiCopyPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(707, 429);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MineTool v1.7.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelFileFinder.ResumeLayout(false);
            this.panelFileFinder.PerformLayout();
            this.panelPasswordHashUtility.ResumeLayout(false);
            this.panelPasswordHashUtility.PerformLayout();
            this.grpAlgorithm.ResumeLayout(false);
            this.grpAlgorithm.PerformLayout();
            this.panelPortScanner.ResumeLayout(false);
            this.panelPortScanner.PerformLayout();
            this.panelRemoteDesktop.ResumeLayout(false);
            this.panelRemoteDesktop.PerformLayout();
            this.panelLocalUsers.ResumeLayout(false);
            this.panelLocalUsers.PerformLayout();
            this.panelDiskManagement.ResumeLayout(false);
            this.panelDiskManagement.PerformLayout();
            this.panelDeviceManager.ResumeLayout(false);
            this.panelDeviceManager.PerformLayout();
            this.panelComputerManagement.ResumeLayout(false);
            this.panelComputerManagement.PerformLayout();
            this.panelServices.ResumeLayout(false);
            this.panelServices.PerformLayout();
            this.panelEventViewer.ResumeLayout(false);
            this.panelEventViewer.PerformLayout();
            this.panelNetstat.ResumeLayout(false);
            this.panelNetstat.PerformLayout();
            this.panelArp.ResumeLayout(false);
            this.panelArp.PerformLayout();
            this.panelTcpPort.ResumeLayout(false);
            this.panelTcpPort.PerformLayout();
            this.paneltracert.ResumeLayout(false);
            this.paneltracert.PerformLayout();
            this.panelWork.ResumeLayout(false);
            this.panelPing.ResumeLayout(false);
            this.panelPing.PerformLayout();
            this.panelPingSweep.ResumeLayout(false);
            this.panelPingSweep.PerformLayout();
            this.panelNslookup.ResumeLayout(false);
            this.panelNslookup.PerformLayout();
            this.cmsFileFinder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.CheckBox chkContinuous;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRdp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnNslookup;
        private System.Windows.Forms.Button btnPortcktcp;
        private System.Windows.Forms.Button btnTracert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtStartIp;
        private System.Windows.Forms.TextBox txtEndIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPingSweep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelPing;
        private System.Windows.Forms.Button btnPingStop;
        private System.Windows.Forms.CheckBox chkPingContinuous;
        private System.Windows.Forms.Label lblPingTitle;
        private System.Windows.Forms.Button btnPingRun;
        private System.Windows.Forms.TextBox txtPingHost;
        private System.Windows.Forms.Panel panelPingSweep;
        private System.Windows.Forms.Label lblPingSweep;
        private System.Windows.Forms.Button btnPingSweepStop;
        private System.Windows.Forms.Button btnPingSweepRun;
        private System.Windows.Forms.TextBox txtSweepEndIp;
        private System.Windows.Forms.TextBox txtSweepStartIp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelNslookup;
        private System.Windows.Forms.Button btnNslookupRun;
        private System.Windows.Forms.TextBox txtNslookupHost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel paneltracert;
        private System.Windows.Forms.Button btnTracertStop;
        private System.Windows.Forms.Button btnTracertRun;
        private System.Windows.Forms.TextBox txtTracertHost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelTcpPort;
        private System.Windows.Forms.TextBox txtTcpHost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTcpPortRun;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.Panel panelArp;
        private System.Windows.Forms.Button btnArpRun;
        private System.Windows.Forms.TextBox txtArpHost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelNetstat;
        private System.Windows.Forms.Button btnNetstatRun;
        private System.Windows.Forms.CheckBox chkNetstatNumeric;
        private System.Windows.Forms.CheckBox chkNetstatAll;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnNetstatStop;
        private System.Windows.Forms.Panel panelEventViewer;
        private System.Windows.Forms.Button btnEventViewerRun;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEventViewerSecurity;
        private System.Windows.Forms.Button btnEventViewerApplication;
        private System.Windows.Forms.Button btnEventViewerSystem;
        private System.Windows.Forms.Panel panelServices;
        private System.Windows.Forms.Button btnServicesRun;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panelComputerManagement;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnComputerManagementRun;
        private System.Windows.Forms.Panel panelDeviceManager;
        private System.Windows.Forms.Button btnDeviceManagerRun;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panelDiskManagement;
        private System.Windows.Forms.Button btnDiskManagementRun;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panelLocalUsers;
        private System.Windows.Forms.Button btnLocalUsersRun;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panelRemoteDesktop;
        private System.Windows.Forms.Button btnRemoteDesktopRun;
        private System.Windows.Forms.TextBox txtRemoteDesktopHost;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelPortScanner;
        private System.Windows.Forms.TextBox txtPortScannerHost;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPortScannerEndPort;
        private System.Windows.Forms.TextBox txtPortScannerStartPort;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnPortScannerStop;
        private System.Windows.Forms.Button btnPortScannerRun;
        private System.Windows.Forms.Panel panelPasswordHashUtility;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RadioButton rdoSHA512;
        private System.Windows.Forms.RadioButton rdoSHA384;
        private System.Windows.Forms.RadioButton rdoSHA256;
        private System.Windows.Forms.RadioButton rdoSHA1;
        private System.Windows.Forms.RadioButton rdoMD5;
        private System.Windows.Forms.GroupBox grpAlgorithm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerateHash;
        private System.Windows.Forms.Button btnCopyHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Panel panelFileFinder;
        private System.Windows.Forms.TextBox txtFileFinderPath;
        private System.Windows.Forms.Label lblFileFinderPath;
        private System.Windows.Forms.Button btnFileFinderRun;
        private System.Windows.Forms.TextBox txtFileFinderKeyword;
        private System.Windows.Forms.Button btnFileFinderBrowse;
        private System.Windows.Forms.Label lblFileFinderKeyword;
        private System.Windows.Forms.Button btnFileFinderStop;
        private System.Windows.Forms.Label lblFileFinderPattern;
        private System.Windows.Forms.ListBox lstFileFinderResults;
        private System.Windows.Forms.TextBox txtFileFinderPattern;
        private System.Windows.Forms.Label lblFileFinderStatus;
        private System.Windows.Forms.CheckBox chkFileFinderEverything;
        private System.Windows.Forms.ContextMenuStrip cmsFileFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyPath;
    }
}

