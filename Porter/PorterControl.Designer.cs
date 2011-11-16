namespace Porter
{
    partial class PorterControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorterControl));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNginxStart = new System.Windows.Forms.Button();
            this.buttonNginxStop = new System.Windows.Forms.Button();
            this.buttonNginxReload = new System.Windows.Forms.Button();
            this.watchdog = new System.Windows.Forms.Timer(this.components);
            this.labelNginxState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPHPStart = new System.Windows.Forms.Button();
            this.labelPHPState = new System.Windows.Forms.Label();
            this.buttonPHPStop = new System.Windows.Forms.Button();
            this.buttonPHPReload = new System.Windows.Forms.Button();
            this.PorterNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonPHPConfigure = new System.Windows.Forms.Button();
            this.buttonNginxConfigure = new System.Windows.Forms.Button();
            this.updateAvailable = new System.Windows.Forms.LinkLabel();
            this.buttonMySQLReload = new System.Windows.Forms.Button();
            this.buttonMySQLStop = new System.Windows.Forms.Button();
            this.labelMySQLState = new System.Windows.Forms.Label();
            this.buttonMySQLStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMySQLConfigure = new System.Windows.Forms.Button();
            this.buttonStartAll = new System.Windows.Forms.Button();
            this.buttonStopAll = new System.Windows.Forms.Button();
            this.buttonReloadAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageController = new System.Windows.Forms.TabPage();
            this.buttonHtdocsOpen = new System.Windows.Forms.Button();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxCheckAvailiablePorts = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.richTextBoxLicenseInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelPorterHome = new System.Windows.Forms.LinkLabel();
            this.labelPorterVersion = new System.Windows.Forms.Label();
            this.labelDummy1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageController.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nginx:";
            // 
            // buttonNginxStart
            // 
            this.buttonNginxStart.Enabled = false;
            this.buttonNginxStart.Location = new System.Drawing.Point(133, 22);
            this.buttonNginxStart.Name = "buttonNginxStart";
            this.buttonNginxStart.Size = new System.Drawing.Size(75, 23);
            this.buttonNginxStart.TabIndex = 1;
            this.buttonNginxStart.Text = "Start";
            this.buttonNginxStart.UseVisualStyleBackColor = true;
            this.buttonNginxStart.Click += new System.EventHandler(this.buttonStartNginx_Click);
            // 
            // buttonNginxStop
            // 
            this.buttonNginxStop.Enabled = false;
            this.buttonNginxStop.Location = new System.Drawing.Point(215, 22);
            this.buttonNginxStop.Name = "buttonNginxStop";
            this.buttonNginxStop.Size = new System.Drawing.Size(75, 23);
            this.buttonNginxStop.TabIndex = 2;
            this.buttonNginxStop.Text = "Stop";
            this.buttonNginxStop.UseVisualStyleBackColor = true;
            this.buttonNginxStop.Click += new System.EventHandler(this.buttonStopNginx_Click);
            // 
            // buttonNginxReload
            // 
            this.buttonNginxReload.Enabled = false;
            this.buttonNginxReload.Location = new System.Drawing.Point(297, 22);
            this.buttonNginxReload.Name = "buttonNginxReload";
            this.buttonNginxReload.Size = new System.Drawing.Size(75, 23);
            this.buttonNginxReload.TabIndex = 3;
            this.buttonNginxReload.Text = "Reload";
            this.buttonNginxReload.UseVisualStyleBackColor = true;
            this.buttonNginxReload.Click += new System.EventHandler(this.buttonReloadNginx_Click);
            // 
            // watchdog
            // 
            this.watchdog.Enabled = true;
            this.watchdog.Interval = 1000;
            this.watchdog.Tick += new System.EventHandler(this.watchdog_Tick);
            // 
            // labelNginxState
            // 
            this.labelNginxState.AutoSize = true;
            this.labelNginxState.ForeColor = System.Drawing.Color.Orange;
            this.labelNginxState.Location = new System.Drawing.Point(58, 26);
            this.labelNginxState.Name = "labelNginxState";
            this.labelNginxState.Size = new System.Drawing.Size(48, 15);
            this.labelNginxState.TabIndex = 4;
            this.labelNginxState.Text = "Waiting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "PHP:";
            // 
            // buttonPHPStart
            // 
            this.buttonPHPStart.Enabled = false;
            this.buttonPHPStart.Location = new System.Drawing.Point(133, 68);
            this.buttonPHPStart.Name = "buttonPHPStart";
            this.buttonPHPStart.Size = new System.Drawing.Size(75, 23);
            this.buttonPHPStart.TabIndex = 6;
            this.buttonPHPStart.Text = "Start";
            this.buttonPHPStart.UseVisualStyleBackColor = true;
            this.buttonPHPStart.Click += new System.EventHandler(this.buttonStartPhp_Click);
            // 
            // labelPHPState
            // 
            this.labelPHPState.AutoSize = true;
            this.labelPHPState.ForeColor = System.Drawing.Color.Orange;
            this.labelPHPState.Location = new System.Drawing.Point(58, 72);
            this.labelPHPState.Name = "labelPHPState";
            this.labelPHPState.Size = new System.Drawing.Size(48, 15);
            this.labelPHPState.TabIndex = 7;
            this.labelPHPState.Text = "Waiting";
            // 
            // buttonPHPStop
            // 
            this.buttonPHPStop.Enabled = false;
            this.buttonPHPStop.Location = new System.Drawing.Point(215, 68);
            this.buttonPHPStop.Name = "buttonPHPStop";
            this.buttonPHPStop.Size = new System.Drawing.Size(75, 23);
            this.buttonPHPStop.TabIndex = 8;
            this.buttonPHPStop.Text = "Stop";
            this.buttonPHPStop.UseVisualStyleBackColor = true;
            this.buttonPHPStop.Click += new System.EventHandler(this.buttonStopPHP_Click);
            // 
            // buttonPHPReload
            // 
            this.buttonPHPReload.Enabled = false;
            this.buttonPHPReload.Location = new System.Drawing.Point(297, 68);
            this.buttonPHPReload.Name = "buttonPHPReload";
            this.buttonPHPReload.Size = new System.Drawing.Size(75, 23);
            this.buttonPHPReload.TabIndex = 9;
            this.buttonPHPReload.Text = "Reload";
            this.buttonPHPReload.UseVisualStyleBackColor = true;
            this.buttonPHPReload.Click += new System.EventHandler(this.buttonPHPReload_Click);
            // 
            // PorterNotify
            // 
            this.PorterNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("PorterNotify.Icon")));
            this.PorterNotify.Text = "Porter Control Center";
            this.PorterNotify.Visible = true;
            this.PorterNotify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PorterNotify_MouseClick);
            // 
            // buttonPHPConfigure
            // 
            this.buttonPHPConfigure.Location = new System.Drawing.Point(378, 68);
            this.buttonPHPConfigure.Name = "buttonPHPConfigure";
            this.buttonPHPConfigure.Size = new System.Drawing.Size(75, 23);
            this.buttonPHPConfigure.TabIndex = 10;
            this.buttonPHPConfigure.Text = "Configure";
            this.buttonPHPConfigure.UseVisualStyleBackColor = true;
            this.buttonPHPConfigure.Click += new System.EventHandler(this.buttonPHPConfigure_Click);
            // 
            // buttonNginxConfigure
            // 
            this.buttonNginxConfigure.Location = new System.Drawing.Point(378, 22);
            this.buttonNginxConfigure.Name = "buttonNginxConfigure";
            this.buttonNginxConfigure.Size = new System.Drawing.Size(75, 23);
            this.buttonNginxConfigure.TabIndex = 11;
            this.buttonNginxConfigure.Text = "Configure";
            this.buttonNginxConfigure.UseVisualStyleBackColor = true;
            this.buttonNginxConfigure.Click += new System.EventHandler(this.buttonNginxConfigure_Click);
            // 
            // updateAvailable
            // 
            this.updateAvailable.ActiveLinkColor = System.Drawing.Color.Green;
            this.updateAvailable.AutoSize = true;
            this.updateAvailable.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.updateAvailable.Enabled = false;
            this.updateAvailable.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateAvailable.Location = new System.Drawing.Point(393, 250);
            this.updateAvailable.Name = "updateAvailable";
            this.updateAvailable.Size = new System.Drawing.Size(16, 15);
            this.updateAvailable.TabIndex = 12;
            this.updateAvailable.TabStop = true;
            this.updateAvailable.Text = "...";
            this.updateAvailable.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateAvailable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateAvailable_LinkClicked);
            // 
            // buttonMySQLReload
            // 
            this.buttonMySQLReload.Enabled = false;
            this.buttonMySQLReload.Location = new System.Drawing.Point(297, 114);
            this.buttonMySQLReload.Name = "buttonMySQLReload";
            this.buttonMySQLReload.Size = new System.Drawing.Size(75, 23);
            this.buttonMySQLReload.TabIndex = 17;
            this.buttonMySQLReload.Text = "Reload";
            this.buttonMySQLReload.UseVisualStyleBackColor = true;
            this.buttonMySQLReload.Click += new System.EventHandler(this.buttonMySQLReload_Click);
            // 
            // buttonMySQLStop
            // 
            this.buttonMySQLStop.Enabled = false;
            this.buttonMySQLStop.Location = new System.Drawing.Point(215, 114);
            this.buttonMySQLStop.Name = "buttonMySQLStop";
            this.buttonMySQLStop.Size = new System.Drawing.Size(75, 23);
            this.buttonMySQLStop.TabIndex = 16;
            this.buttonMySQLStop.Text = "Stop";
            this.buttonMySQLStop.UseVisualStyleBackColor = true;
            this.buttonMySQLStop.Click += new System.EventHandler(this.buttonMySQLStop_Click);
            // 
            // labelMySQLState
            // 
            this.labelMySQLState.AutoSize = true;
            this.labelMySQLState.ForeColor = System.Drawing.Color.Orange;
            this.labelMySQLState.Location = new System.Drawing.Point(58, 118);
            this.labelMySQLState.Name = "labelMySQLState";
            this.labelMySQLState.Size = new System.Drawing.Size(48, 15);
            this.labelMySQLState.TabIndex = 15;
            this.labelMySQLState.Text = "Waiting";
            // 
            // buttonMySQLStart
            // 
            this.buttonMySQLStart.Enabled = false;
            this.buttonMySQLStart.Location = new System.Drawing.Point(133, 114);
            this.buttonMySQLStart.Name = "buttonMySQLStart";
            this.buttonMySQLStart.Size = new System.Drawing.Size(75, 23);
            this.buttonMySQLStart.TabIndex = 14;
            this.buttonMySQLStart.Text = "Start";
            this.buttonMySQLStart.UseVisualStyleBackColor = true;
            this.buttonMySQLStart.Click += new System.EventHandler(this.buttonMySQLStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(10, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "MySQL:";
            // 
            // buttonMySQLConfigure
            // 
            this.buttonMySQLConfigure.Location = new System.Drawing.Point(378, 114);
            this.buttonMySQLConfigure.Name = "buttonMySQLConfigure";
            this.buttonMySQLConfigure.Size = new System.Drawing.Size(75, 23);
            this.buttonMySQLConfigure.TabIndex = 18;
            this.buttonMySQLConfigure.Text = "Configure";
            this.buttonMySQLConfigure.UseVisualStyleBackColor = true;
            this.buttonMySQLConfigure.Click += new System.EventHandler(this.buttonMySQLConfigure_Click);
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.Location = new System.Drawing.Point(134, 160);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAll.TabIndex = 19;
            this.buttonStartAll.Text = "Start All";
            this.buttonStartAll.UseVisualStyleBackColor = true;
            this.buttonStartAll.Click += new System.EventHandler(this.buttonStartAll_Click);
            // 
            // buttonStopAll
            // 
            this.buttonStopAll.Location = new System.Drawing.Point(215, 160);
            this.buttonStopAll.Name = "buttonStopAll";
            this.buttonStopAll.Size = new System.Drawing.Size(75, 23);
            this.buttonStopAll.TabIndex = 20;
            this.buttonStopAll.Text = "Stop All";
            this.buttonStopAll.UseVisualStyleBackColor = true;
            this.buttonStopAll.Click += new System.EventHandler(this.buttonStopAll_Click);
            // 
            // buttonReloadAll
            // 
            this.buttonReloadAll.Location = new System.Drawing.Point(297, 160);
            this.buttonReloadAll.Name = "buttonReloadAll";
            this.buttonReloadAll.Size = new System.Drawing.Size(75, 23);
            this.buttonReloadAll.TabIndex = 21;
            this.buttonReloadAll.Text = "Reload All";
            this.buttonReloadAll.UseVisualStyleBackColor = true;
            this.buttonReloadAll.Click += new System.EventHandler(this.buttonReloadAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageController);
            this.tabControl1.Controls.Add(this.tabPageOptions);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 300);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPageController
            // 
            this.tabPageController.BackColor = System.Drawing.Color.White;
            this.tabPageController.Controls.Add(this.buttonHtdocsOpen);
            this.tabPageController.Controls.Add(this.buttonPHPConfigure);
            this.tabPageController.Controls.Add(this.updateAvailable);
            this.tabPageController.Controls.Add(this.buttonReloadAll);
            this.tabPageController.Controls.Add(this.label1);
            this.tabPageController.Controls.Add(this.buttonStopAll);
            this.tabPageController.Controls.Add(this.buttonNginxStart);
            this.tabPageController.Controls.Add(this.buttonStartAll);
            this.tabPageController.Controls.Add(this.buttonNginxStop);
            this.tabPageController.Controls.Add(this.buttonMySQLConfigure);
            this.tabPageController.Controls.Add(this.buttonNginxReload);
            this.tabPageController.Controls.Add(this.buttonMySQLReload);
            this.tabPageController.Controls.Add(this.labelNginxState);
            this.tabPageController.Controls.Add(this.buttonMySQLStop);
            this.tabPageController.Controls.Add(this.label2);
            this.tabPageController.Controls.Add(this.labelMySQLState);
            this.tabPageController.Controls.Add(this.buttonPHPStart);
            this.tabPageController.Controls.Add(this.buttonMySQLStart);
            this.tabPageController.Controls.Add(this.labelPHPState);
            this.tabPageController.Controls.Add(this.label4);
            this.tabPageController.Controls.Add(this.buttonPHPStop);
            this.tabPageController.Controls.Add(this.buttonPHPReload);
            this.tabPageController.Controls.Add(this.buttonNginxConfigure);
            this.tabPageController.Location = new System.Drawing.Point(4, 26);
            this.tabPageController.Name = "tabPageController";
            this.tabPageController.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageController.Size = new System.Drawing.Size(473, 270);
            this.tabPageController.TabIndex = 0;
            this.tabPageController.Text = "Controller";
            // 
            // buttonHtdocsOpen
            // 
            this.buttonHtdocsOpen.Location = new System.Drawing.Point(378, 160);
            this.buttonHtdocsOpen.Name = "buttonHtdocsOpen";
            this.buttonHtdocsOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonHtdocsOpen.TabIndex = 22;
            this.buttonHtdocsOpen.Text = "Htdocs";
            this.buttonHtdocsOpen.UseVisualStyleBackColor = true;
            this.buttonHtdocsOpen.Click += new System.EventHandler(this.buttonHtdocsOpen_Click);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.panel1);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 26);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(473, 270);
            this.tabPageOptions.TabIndex = 1;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBoxCheckAvailiablePorts);
            this.panel1.Controls.Add(this.checkBoxCheckForUpdates);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 264);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxCheckAvailiablePorts
            // 
            this.checkBoxCheckAvailiablePorts.AutoSize = true;
            this.checkBoxCheckAvailiablePorts.Location = new System.Drawing.Point(16, 45);
            this.checkBoxCheckAvailiablePorts.Name = "checkBoxCheckAvailiablePorts";
            this.checkBoxCheckAvailiablePorts.Size = new System.Drawing.Size(181, 19);
            this.checkBoxCheckAvailiablePorts.TabIndex = 2;
            this.checkBoxCheckAvailiablePorts.Text = "Check for available TCP ports";
            this.checkBoxCheckAvailiablePorts.UseVisualStyleBackColor = true;
            this.checkBoxCheckAvailiablePorts.CheckedChanged += new System.EventHandler(this.checkBoxCheckAvailiablePorts_CheckedChanged);
            // 
            // checkBoxCheckForUpdates
            // 
            this.checkBoxCheckForUpdates.AutoSize = true;
            this.checkBoxCheckForUpdates.Checked = true;
            this.checkBoxCheckForUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckForUpdates.Location = new System.Drawing.Point(16, 19);
            this.checkBoxCheckForUpdates.Name = "checkBoxCheckForUpdates";
            this.checkBoxCheckForUpdates.Size = new System.Drawing.Size(179, 19);
            this.checkBoxCheckForUpdates.TabIndex = 1;
            this.checkBoxCheckForUpdates.Text = "Check for updates on startup";
            this.checkBoxCheckForUpdates.UseVisualStyleBackColor = true;
            this.checkBoxCheckForUpdates.CheckedChanged += new System.EventHandler(this.checkBoxCheckForUpdates_CheckedChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.Color.White;
            this.tabPageAbout.Controls.Add(this.linkLabel1);
            this.tabPageAbout.Controls.Add(this.richTextBoxLicenseInfo);
            this.tabPageAbout.Controls.Add(this.label3);
            this.tabPageAbout.Controls.Add(this.linkLabelPorterHome);
            this.tabPageAbout.Controls.Add(this.labelPorterVersion);
            this.tabPageAbout.Controls.Add(this.labelDummy1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 26);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(473, 270);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 58);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(229, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://sourceforge.net/projects/litporter/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // richTextBoxLicenseInfo
            // 
            this.richTextBoxLicenseInfo.BackColor = System.Drawing.Color.White;
            this.richTextBoxLicenseInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.richTextBoxLicenseInfo.Location = new System.Drawing.Point(24, 101);
            this.richTextBoxLicenseInfo.Name = "richTextBoxLicenseInfo";
            this.richTextBoxLicenseInfo.ReadOnly = true;
            this.richTextBoxLicenseInfo.Size = new System.Drawing.Size(441, 161);
            this.richTextBoxLicenseInfo.TabIndex = 4;
            this.richTextBoxLicenseInfo.Text = resources.GetString("richTextBoxLicenseInfo.Text");
            this.richTextBoxLicenseInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxLicenseInfo_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright © 2011 LIT Software";
            // 
            // linkLabelPorterHome
            // 
            this.linkLabelPorterHome.AutoSize = true;
            this.linkLabelPorterHome.Location = new System.Drawing.Point(21, 58);
            this.linkLabelPorterHome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.linkLabelPorterHome.Name = "linkLabelPorterHome";
            this.linkLabelPorterHome.Size = new System.Drawing.Size(99, 15);
            this.linkLabelPorterHome.TabIndex = 2;
            this.linkLabelPorterHome.TabStop = true;
            this.linkLabelPorterHome.Text = "http://porter.lit.lv";
            this.linkLabelPorterHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPorterHome_LinkClicked);
            // 
            // labelPorterVersion
            // 
            this.labelPorterVersion.AutoSize = true;
            this.labelPorterVersion.Location = new System.Drawing.Point(21, 38);
            this.labelPorterVersion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelPorterVersion.Name = "labelPorterVersion";
            this.labelPorterVersion.Size = new System.Drawing.Size(46, 15);
            this.labelPorterVersion.TabIndex = 1;
            this.labelPorterVersion.Text = "v0.0.0.0";
            // 
            // labelDummy1
            // 
            this.labelDummy1.AutoSize = true;
            this.labelDummy1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelDummy1.Location = new System.Drawing.Point(21, 16);
            this.labelDummy1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.labelDummy1.Name = "labelDummy1";
            this.labelDummy1.Size = new System.Drawing.Size(69, 17);
            this.labelDummy1.TabIndex = 0;
            this.labelDummy1.Text = "LIT Porter";
            // 
            // PorterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 300);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(497, 338);
            this.Name = "PorterControl";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porter Controller";
            this.Resize += new System.EventHandler(this.PorterControl_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPageController.ResumeLayout(false);
            this.tabPageController.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNginxStart;
        private System.Windows.Forms.Button buttonNginxStop;
        private System.Windows.Forms.Button buttonNginxReload;
        private System.Windows.Forms.Timer watchdog;
        private System.Windows.Forms.Label labelNginxState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPHPStart;
        private System.Windows.Forms.Label labelPHPState;
        private System.Windows.Forms.Button buttonPHPStop;
        private System.Windows.Forms.Button buttonPHPReload;
        private System.Windows.Forms.NotifyIcon PorterNotify;
        private System.Windows.Forms.Button buttonPHPConfigure;
        private System.Windows.Forms.Button buttonNginxConfigure;
        private System.Windows.Forms.LinkLabel updateAvailable;
        private System.Windows.Forms.Button buttonMySQLReload;
        private System.Windows.Forms.Button buttonMySQLStop;
        private System.Windows.Forms.Label labelMySQLState;
        private System.Windows.Forms.Button buttonMySQLStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMySQLConfigure;
        private System.Windows.Forms.Button buttonStartAll;
        private System.Windows.Forms.Button buttonStopAll;
        private System.Windows.Forms.Button buttonReloadAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageController;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label labelDummy1;
        private System.Windows.Forms.Label labelPorterVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelPorterHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxCheckForUpdates;
        private System.Windows.Forms.CheckBox checkBoxCheckAvailiablePorts;
        private System.Windows.Forms.Button buttonHtdocsOpen;
        private System.Windows.Forms.RichTextBox richTextBoxLicenseInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

