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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ping");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ping Sweep");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("nslookup");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("tracert");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("TCP Port");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("ARP");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Netstat");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Network", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Event Viewer");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Services");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Computer Management");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Windows", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Server");
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
            this.btnComputerManagement = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnEventViewer = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.paneltracert = new System.Windows.Forms.Panel();
            this.btnTracertStop = new System.Windows.Forms.Button();
            this.btnTracertRun = new System.Windows.Forms.Button();
            this.txtTracertHost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTcpPort = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTcpHost = new System.Windows.Forms.TextBox();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTcpPortRun = new System.Windows.Forms.Button();
            this.panelArp = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtArpHost = new System.Windows.Forms.TextBox();
            this.btnArpRun = new System.Windows.Forms.Button();
            this.panelNetstat = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.chkNetstatAll = new System.Windows.Forms.CheckBox();
            this.chkNetstatNumeric = new System.Windows.Forms.CheckBox();
            this.btnNetstatRun = new System.Windows.Forms.Button();
            this.btnNetstatStop = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.panelPing.SuspendLayout();
            this.panelPingSweep.SuspendLayout();
            this.panelNslookup.SuspendLayout();
            this.paneltracert.SuspendLayout();
            this.panelTcpPort.SuspendLayout();
            this.panelArp.SuspendLayout();
            this.panelNetstat.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 230);
            this.textBox1.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(5, 31);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(200, 25);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "8.8.8.8";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // chkContinuous
            // 
            this.chkContinuous.AutoSize = true;
            this.chkContinuous.Location = new System.Drawing.Point(4, 69);
            this.chkContinuous.Name = "chkContinuous";
            this.chkContinuous.Size = new System.Drawing.Size(95, 22);
            this.chkContinuous.TabIndex = 3;
            this.chkContinuous.Text = "継続(-t)";
            this.chkContinuous.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(4, 133);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 35);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host/IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRdp
            // 
            this.btnRdp.Location = new System.Drawing.Point(4, 174);
            this.btnRdp.Name = "btnRdp";
            this.btnRdp.Size = new System.Drawing.Size(118, 35);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 448);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 416);
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
            this.panel1.Location = new System.Drawing.Point(19, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 492);
            this.panel1.TabIndex = 8;
            // 
            // btnPingSweep
            // 
            this.btnPingSweep.Location = new System.Drawing.Point(4, 90);
            this.btnPingSweep.Name = "btnPingSweep";
            this.btnPingSweep.Size = new System.Drawing.Size(192, 35);
            this.btnPingSweep.TabIndex = 17;
            this.btnPingSweep.Text = "Ping Sweep";
            this.btnPingSweep.UseVisualStyleBackColor = true;
            this.btnPingSweep.Click += new System.EventHandler(this.btnPingSweep_Click);
            // 
            // btnNslookup
            // 
            this.btnNslookup.Location = new System.Drawing.Point(4, 215);
            this.btnNslookup.Name = "btnNslookup";
            this.btnNslookup.Size = new System.Drawing.Size(129, 35);
            this.btnNslookup.TabIndex = 7;
            this.btnNslookup.Text = "nslookup";
            this.btnNslookup.UseVisualStyleBackColor = true;
            this.btnNslookup.Click += new System.EventHandler(this.btnNslookup_Click);
            // 
            // btnTracert
            // 
            this.btnTracert.Location = new System.Drawing.Point(4, 256);
            this.btnTracert.Name = "btnTracert";
            this.btnTracert.Size = new System.Drawing.Size(95, 35);
            this.btnTracert.TabIndex = 8;
            this.btnTracert.Text = "tracert";
            this.btnTracert.UseVisualStyleBackColor = true;
            this.btnTracert.Click += new System.EventHandler(this.btnTracert_Click);
            // 
            // btnPortcktcp
            // 
            this.btnPortcktcp.Location = new System.Drawing.Point(0, 297);
            this.btnPortcktcp.Name = "btnPortcktcp";
            this.btnPortcktcp.Size = new System.Drawing.Size(163, 35);
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
            this.panel2.Location = new System.Drawing.Point(265, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 303);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sweep to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sweep from";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(211, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "3389";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtStartIp
            // 
            this.txtStartIp.Location = new System.Drawing.Point(341, 31);
            this.txtStartIp.Name = "txtStartIp";
            this.txtStartIp.Size = new System.Drawing.Size(200, 25);
            this.txtStartIp.TabIndex = 13;
            this.txtStartIp.Text = "192.168.2.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // txtEndIp
            // 
            this.txtEndIp.Location = new System.Drawing.Point(575, 31);
            this.txtEndIp.Name = "txtEndIp";
            this.txtEndIp.Size = new System.Drawing.Size(200, 25);
            this.txtEndIp.TabIndex = 12;
            this.txtEndIp.Text = "192.168.2.254";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Windows";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "サーバ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnComputerManagement
            // 
            this.btnComputerManagement.Location = new System.Drawing.Point(26, 515);
            this.btnComputerManagement.Name = "btnComputerManagement";
            this.btnComputerManagement.Size = new System.Drawing.Size(200, 35);
            this.btnComputerManagement.TabIndex = 2;
            this.btnComputerManagement.Text = "コンピューターの管理";
            this.btnComputerManagement.UseVisualStyleBackColor = true;
            this.btnComputerManagement.Click += new System.EventHandler(this.btnComputerManagement_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(30, 474);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(138, 35);
            this.btnServices.TabIndex = 1;
            this.btnServices.Text = "サービス";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnEventViewer
            // 
            this.btnEventViewer.Location = new System.Drawing.Point(26, 433);
            this.btnEventViewer.Name = "btnEventViewer";
            this.btnEventViewer.Size = new System.Drawing.Size(138, 35);
            this.btnEventViewer.TabIndex = 0;
            this.btnEventViewer.Text = "イベントビューア";
            this.btnEventViewer.UseVisualStyleBackColor = true;
            this.btnEventViewer.Click += new System.EventHandler(this.btnEventViewer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelNetstat);
            this.splitContainer1.Panel2.Controls.Add(this.panelArp);
            this.splitContainer1.Panel2.Controls.Add(this.panelTcpPort);
            this.splitContainer1.Panel2.Controls.Add(this.paneltracert);
            this.splitContainer1.Panel2.Controls.Add(this.panelWork);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 644);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 13);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "ping";
            treeNode14.Text = "Ping";
            treeNode15.Name = "pingSweep";
            treeNode15.Text = "Ping Sweep";
            treeNode16.Name = "nslookup";
            treeNode16.Text = "nslookup";
            treeNode17.Name = "tracert";
            treeNode17.Text = "tracert";
            treeNode18.Name = "tcpPort";
            treeNode18.Text = "TCP Port";
            treeNode19.Name = "arp";
            treeNode19.Text = "ARP";
            treeNode20.Name = "netstat";
            treeNode20.Text = "Netstat";
            treeNode21.Name = "network";
            treeNode21.Text = "Network";
            treeNode22.Name = "eventViewer";
            treeNode22.Text = "Event Viewer";
            treeNode23.Name = "services";
            treeNode23.Text = "Services";
            treeNode24.Name = "computerManagement";
            treeNode24.Text = "Computer Management";
            treeNode25.Name = "windows";
            treeNode25.Text = "Windows";
            treeNode26.Name = "server";
            treeNode26.Text = "Server";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(210, 475);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.panelWork.Location = new System.Drawing.Point(4, 75);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(947, 193);
            this.panelWork.TabIndex = 1;
            // 
            // panelPing
            // 
            this.panelPing.Controls.Add(this.btnPingStop);
            this.panelPing.Controls.Add(this.chkPingContinuous);
            this.panelPing.Controls.Add(this.lblPingTitle);
            this.panelPing.Controls.Add(this.btnPingRun);
            this.panelPing.Controls.Add(this.txtPingHost);
            this.panelPing.Location = new System.Drawing.Point(3, 3);
            this.panelPing.Name = "panelPing";
            this.panelPing.Size = new System.Drawing.Size(939, 185);
            this.panelPing.TabIndex = 8;
            // 
            // btnPingStop
            // 
            this.btnPingStop.Location = new System.Drawing.Point(123, 100);
            this.btnPingStop.Name = "btnPingStop";
            this.btnPingStop.Size = new System.Drawing.Size(100, 30);
            this.btnPingStop.TabIndex = 5;
            this.btnPingStop.Text = "停止";
            this.btnPingStop.UseVisualStyleBackColor = true;
            // 
            // chkPingContinuous
            // 
            this.chkPingContinuous.AutoSize = true;
            this.chkPingContinuous.Location = new System.Drawing.Point(17, 72);
            this.chkPingContinuous.Name = "chkPingContinuous";
            this.chkPingContinuous.Size = new System.Drawing.Size(131, 22);
            this.chkPingContinuous.TabIndex = 4;
            this.chkPingContinuous.Text = "継続実行(-t)";
            this.chkPingContinuous.UseVisualStyleBackColor = true;
            // 
            // lblPingTitle
            // 
            this.lblPingTitle.AutoSize = true;
            this.lblPingTitle.Location = new System.Drawing.Point(14, 11);
            this.lblPingTitle.Name = "lblPingTitle";
            this.lblPingTitle.Size = new System.Drawing.Size(40, 18);
            this.lblPingTitle.TabIndex = 0;
            this.lblPingTitle.Text = "Ping";
            // 
            // btnPingRun
            // 
            this.btnPingRun.Location = new System.Drawing.Point(17, 100);
            this.btnPingRun.Name = "btnPingRun";
            this.btnPingRun.Size = new System.Drawing.Size(100, 30);
            this.btnPingRun.TabIndex = 2;
            this.btnPingRun.Text = "Ping";
            this.btnPingRun.UseVisualStyleBackColor = true;
            // 
            // txtPingHost
            // 
            this.txtPingHost.Location = new System.Drawing.Point(17, 35);
            this.txtPingHost.Name = "txtPingHost";
            this.txtPingHost.Size = new System.Drawing.Size(180, 25);
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
            this.panelPingSweep.Location = new System.Drawing.Point(3, 3);
            this.panelPingSweep.Name = "panelPingSweep";
            this.panelPingSweep.Size = new System.Drawing.Size(939, 185);
            this.panelPingSweep.TabIndex = 9;
            // 
            // lblPingSweep
            // 
            this.lblPingSweep.AutoSize = true;
            this.lblPingSweep.Location = new System.Drawing.Point(14, 11);
            this.lblPingSweep.Name = "lblPingSweep";
            this.lblPingSweep.Size = new System.Drawing.Size(95, 18);
            this.lblPingSweep.TabIndex = 6;
            this.lblPingSweep.Text = "Ping Sweep";
            // 
            // btnPingSweepStop
            // 
            this.btnPingSweepStop.Location = new System.Drawing.Point(150, 101);
            this.btnPingSweepStop.Name = "btnPingSweepStop";
            this.btnPingSweepStop.Size = new System.Drawing.Size(100, 30);
            this.btnPingSweepStop.TabIndex = 5;
            this.btnPingSweepStop.Text = "停止";
            this.btnPingSweepStop.UseVisualStyleBackColor = true;
            // 
            // btnPingSweepRun
            // 
            this.btnPingSweepRun.Location = new System.Drawing.Point(17, 101);
            this.btnPingSweepRun.Name = "btnPingSweepRun";
            this.btnPingSweepRun.Size = new System.Drawing.Size(127, 30);
            this.btnPingSweepRun.TabIndex = 4;
            this.btnPingSweepRun.Text = "スキャン開始";
            this.btnPingSweepRun.UseVisualStyleBackColor = true;
            // 
            // txtSweepEndIp
            // 
            this.txtSweepEndIp.Location = new System.Drawing.Point(203, 62);
            this.txtSweepEndIp.Name = "txtSweepEndIp";
            this.txtSweepEndIp.Size = new System.Drawing.Size(180, 25);
            this.txtSweepEndIp.TabIndex = 3;
            this.txtSweepEndIp.Text = "192.168.1.254";
            // 
            // txtSweepStartIp
            // 
            this.txtSweepStartIp.Location = new System.Drawing.Point(17, 62);
            this.txtSweepStartIp.Name = "txtSweepStartIp";
            this.txtSweepStartIp.Size = new System.Drawing.Size(180, 25);
            this.txtSweepStartIp.TabIndex = 2;
            this.txtSweepStartIp.Text = "192.168.1.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "終了IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "開始IP";
            // 
            // panelNslookup
            // 
            this.panelNslookup.Controls.Add(this.btnNslookupRun);
            this.panelNslookup.Controls.Add(this.txtNslookupHost);
            this.panelNslookup.Controls.Add(this.label9);
            this.panelNslookup.Controls.Add(this.label8);
            this.panelNslookup.Location = new System.Drawing.Point(3, 3);
            this.panelNslookup.Name = "panelNslookup";
            this.panelNslookup.Size = new System.Drawing.Size(939, 185);
            this.panelNslookup.TabIndex = 10;
            // 
            // btnNslookupRun
            // 
            this.btnNslookupRun.Location = new System.Drawing.Point(13, 96);
            this.btnNslookupRun.Name = "btnNslookupRun";
            this.btnNslookupRun.Size = new System.Drawing.Size(127, 30);
            this.btnNslookupRun.TabIndex = 3;
            this.btnNslookupRun.Text = "nslookup";
            this.btnNslookupRun.UseVisualStyleBackColor = true;
            // 
            // txtNslookupHost
            // 
            this.txtNslookupHost.Location = new System.Drawing.Point(13, 61);
            this.txtNslookupHost.Name = "txtNslookupHost";
            this.txtNslookupHost.Size = new System.Drawing.Size(180, 25);
            this.txtNslookupHost.TabIndex = 2;
            this.txtNslookupHost.Text = "8.8.8.8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Host/IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "nslookup";
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(939, 185);
            this.panelHome.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(23, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ここに画面タイトル";
            // 
            // paneltracert
            // 
            this.paneltracert.Controls.Add(this.btnTracertStop);
            this.paneltracert.Controls.Add(this.btnTracertRun);
            this.paneltracert.Controls.Add(this.txtTracertHost);
            this.paneltracert.Controls.Add(this.label11);
            this.paneltracert.Controls.Add(this.label10);
            this.paneltracert.Location = new System.Drawing.Point(6, 80);
            this.paneltracert.Name = "paneltracert";
            this.paneltracert.Size = new System.Drawing.Size(943, 185);
            this.paneltracert.TabIndex = 4;
            // 
            // btnTracertStop
            // 
            this.btnTracertStop.Location = new System.Drawing.Point(117, 106);
            this.btnTracertStop.Name = "btnTracertStop";
            this.btnTracertStop.Size = new System.Drawing.Size(100, 30);
            this.btnTracertStop.TabIndex = 4;
            this.btnTracertStop.Text = "停止";
            this.btnTracertStop.UseVisualStyleBackColor = true;
            // 
            // btnTracertRun
            // 
            this.btnTracertRun.Location = new System.Drawing.Point(11, 106);
            this.btnTracertRun.Name = "btnTracertRun";
            this.btnTracertRun.Size = new System.Drawing.Size(100, 30);
            this.btnTracertRun.TabIndex = 3;
            this.btnTracertRun.Text = "tracert";
            this.btnTracertRun.UseVisualStyleBackColor = true;
            // 
            // txtTracertHost
            // 
            this.txtTracertHost.Location = new System.Drawing.Point(11, 63);
            this.txtTracertHost.Name = "txtTracertHost";
            this.txtTracertHost.Size = new System.Drawing.Size(180, 25);
            this.txtTracertHost.TabIndex = 2;
            this.txtTracertHost.Text = "8.8.8.8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Host/IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "tracert";
            // 
            // panelTcpPort
            // 
            this.panelTcpPort.Controls.Add(this.btnTcpPortRun);
            this.panelTcpPort.Controls.Add(this.label14);
            this.panelTcpPort.Controls.Add(this.txtTcpPort);
            this.panelTcpPort.Controls.Add(this.txtTcpHost);
            this.panelTcpPort.Controls.Add(this.label13);
            this.panelTcpPort.Controls.Add(this.label12);
            this.panelTcpPort.Location = new System.Drawing.Point(7, 80);
            this.panelTcpPort.Name = "panelTcpPort";
            this.panelTcpPort.Size = new System.Drawing.Size(940, 182);
            this.panelTcpPort.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "TCP Port";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Host/IP";
            // 
            // txtTcpHost
            // 
            this.txtTcpHost.Location = new System.Drawing.Point(13, 54);
            this.txtTcpHost.Name = "txtTcpHost";
            this.txtTcpHost.Size = new System.Drawing.Size(180, 25);
            this.txtTcpHost.TabIndex = 2;
            this.txtTcpHost.Text = "8.8.8.8";
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(13, 117);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(180, 25);
            this.txtTcpPort.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Port（空欄なら主要ポート）";
            // 
            // btnTcpPortRun
            // 
            this.btnTcpPortRun.Location = new System.Drawing.Point(13, 147);
            this.btnTcpPortRun.Name = "btnTcpPortRun";
            this.btnTcpPortRun.Size = new System.Drawing.Size(100, 30);
            this.btnTcpPortRun.TabIndex = 5;
            this.btnTcpPortRun.Text = "Scan";
            this.btnTcpPortRun.UseVisualStyleBackColor = true;
            this.btnTcpPortRun.Click += new System.EventHandler(this.btnTcpPortRun_Click);
            // 
            // panelArp
            // 
            this.panelArp.Controls.Add(this.btnArpRun);
            this.panelArp.Controls.Add(this.txtArpHost);
            this.panelArp.Controls.Add(this.label16);
            this.panelArp.Controls.Add(this.label15);
            this.panelArp.Location = new System.Drawing.Point(11, 82);
            this.panelArp.Name = "panelArp";
            this.panelArp.Size = new System.Drawing.Size(935, 184);
            this.panelArp.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "ARP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 18);
            this.label16.TabIndex = 1;
            this.label16.Text = "Host/IP(空欄なら全表示)";
            // 
            // txtArpHost
            // 
            this.txtArpHost.Location = new System.Drawing.Point(6, 53);
            this.txtArpHost.Name = "txtArpHost";
            this.txtArpHost.Size = new System.Drawing.Size(180, 25);
            this.txtArpHost.TabIndex = 2;
            // 
            // btnArpRun
            // 
            this.btnArpRun.Location = new System.Drawing.Point(8, 84);
            this.btnArpRun.Name = "btnArpRun";
            this.btnArpRun.Size = new System.Drawing.Size(100, 30);
            this.btnArpRun.TabIndex = 3;
            this.btnArpRun.Text = "実行";
            this.btnArpRun.UseVisualStyleBackColor = true;
            this.btnArpRun.Click += new System.EventHandler(this.btnArpRun_Click);
            // 
            // panelNetstat
            // 
            this.panelNetstat.Controls.Add(this.btnNetstatStop);
            this.panelNetstat.Controls.Add(this.btnNetstatRun);
            this.panelNetstat.Controls.Add(this.chkNetstatNumeric);
            this.panelNetstat.Controls.Add(this.chkNetstatAll);
            this.panelNetstat.Controls.Add(this.label17);
            this.panelNetstat.Location = new System.Drawing.Point(11, 81);
            this.panelNetstat.Name = "panelNetstat";
            this.panelNetstat.Size = new System.Drawing.Size(935, 184);
            this.panelNetstat.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Netstat";
            // 
            // chkNetstatAll
            // 
            this.chkNetstatAll.AutoSize = true;
            this.chkNetstatAll.Checked = true;
            this.chkNetstatAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetstatAll.Location = new System.Drawing.Point(14, 41);
            this.chkNetstatAll.Name = "chkNetstatAll";
            this.chkNetstatAll.Size = new System.Drawing.Size(142, 22);
            this.chkNetstatAll.TabIndex = 1;
            this.chkNetstatAll.Text = "すべて表示(-a)";
            this.chkNetstatAll.UseVisualStyleBackColor = true;
            // 
            // chkNetstatNumeric
            // 
            this.chkNetstatNumeric.AutoSize = true;
            this.chkNetstatNumeric.Checked = true;
            this.chkNetstatNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetstatNumeric.Location = new System.Drawing.Point(14, 82);
            this.chkNetstatNumeric.Name = "chkNetstatNumeric";
            this.chkNetstatNumeric.Size = new System.Drawing.Size(177, 22);
            this.chkNetstatNumeric.TabIndex = 2;
            this.chkNetstatNumeric.Text = "名前解決しない(-n)";
            this.chkNetstatNumeric.UseVisualStyleBackColor = true;
            // 
            // btnNetstatRun
            // 
            this.btnNetstatRun.Location = new System.Drawing.Point(14, 127);
            this.btnNetstatRun.Name = "btnNetstatRun";
            this.btnNetstatRun.Size = new System.Drawing.Size(100, 30);
            this.btnNetstatRun.TabIndex = 3;
            this.btnNetstatRun.Text = "実行";
            this.btnNetstatRun.UseVisualStyleBackColor = true;
            this.btnNetstatRun.Click += new System.EventHandler(this.btnNetstatRun_Click);
            // 
            // btnNetstatStop
            // 
            this.btnNetstatStop.Location = new System.Drawing.Point(120, 127);
            this.btnNetstatStop.Name = "btnNetstatStop";
            this.btnNetstatStop.Size = new System.Drawing.Size(100, 30);
            this.btnNetstatStop.TabIndex = 4;
            this.btnNetstatStop.Text = "停止";
            this.btnNetstatStop.UseVisualStyleBackColor = true;
            this.btnNetstatStop.Click += new System.EventHandler(this.btnNetstatStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.btnComputerManagement);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnEventViewer);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MineTool v1.0";
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
            this.panelWork.ResumeLayout(false);
            this.panelPing.ResumeLayout(false);
            this.panelPing.PerformLayout();
            this.panelPingSweep.ResumeLayout(false);
            this.panelPingSweep.PerformLayout();
            this.panelNslookup.ResumeLayout(false);
            this.panelNslookup.PerformLayout();
            this.paneltracert.ResumeLayout(false);
            this.paneltracert.PerformLayout();
            this.panelTcpPort.ResumeLayout(false);
            this.panelTcpPort.PerformLayout();
            this.panelArp.ResumeLayout(false);
            this.panelArp.PerformLayout();
            this.panelNetstat.ResumeLayout(false);
            this.panelNetstat.PerformLayout();
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
        private System.Windows.Forms.Button btnEventViewer;
        private System.Windows.Forms.Button btnComputerManagement;
        private System.Windows.Forms.Button btnServices;
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
    }
}

