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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Windows", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Server");
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 644);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 13);
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
            treeNode12.Name = "windows";
            treeNode12.Text = "Windows";
            treeNode13.Name = "server";
            treeNode13.Text = "Server";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(210, 475);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
    }
}

