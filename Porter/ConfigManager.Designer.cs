namespace Porter
{
    partial class ConfigManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMakeActive = new System.Windows.Forms.Button();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxConfigs = new System.Windows.Forms.ListBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelClosePorterControl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTitle, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 408);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 4);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.labelActive);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonMakeActive);
            this.panel1.Controls.Add(this.buttonEditProfile);
            this.panel1.Controls.Add(this.buttonDeleteProfile);
            this.panel1.Controls.Add(this.buttonCreateProfile);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 367);
            this.panel1.TabIndex = 0;
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(134, 27);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(41, 16);
            this.labelActive.TabIndex = 17;
            this.labelActive.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Active profile:";
            // 
            // buttonMakeActive
            // 
            this.buttonMakeActive.AutoSize = true;
            this.buttonMakeActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonMakeActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakeActive.Enabled = false;
            this.buttonMakeActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonMakeActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonMakeActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonMakeActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeActive.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonMakeActive.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonMakeActive.Location = new System.Drawing.Point(353, 58);
            this.buttonMakeActive.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonMakeActive.Name = "buttonMakeActive";
            this.buttonMakeActive.Padding = new System.Windows.Forms.Padding(1);
            this.buttonMakeActive.Size = new System.Drawing.Size(153, 27);
            this.buttonMakeActive.TabIndex = 15;
            this.buttonMakeActive.Text = "Make active";
            this.buttonMakeActive.UseVisualStyleBackColor = false;
            this.buttonMakeActive.Click += new System.EventHandler(this.buttonMakeActive_Click);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.AutoSize = true;
            this.buttonEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditProfile.Enabled = false;
            this.buttonEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonEditProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.buttonEditProfile.Location = new System.Drawing.Point(353, 138);
            this.buttonEditProfile.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Padding = new System.Windows.Forms.Padding(1);
            this.buttonEditProfile.Size = new System.Drawing.Size(153, 27);
            this.buttonEditProfile.TabIndex = 14;
            this.buttonEditProfile.Text = "Edit profile";
            this.buttonEditProfile.UseVisualStyleBackColor = false;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.AutoSize = true;
            this.buttonDeleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonDeleteProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteProfile.Enabled = false;
            this.buttonDeleteProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonDeleteProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonDeleteProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonDeleteProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteProfile.Location = new System.Drawing.Point(353, 178);
            this.buttonDeleteProfile.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Padding = new System.Windows.Forms.Padding(1);
            this.buttonDeleteProfile.Size = new System.Drawing.Size(153, 27);
            this.buttonDeleteProfile.TabIndex = 13;
            this.buttonDeleteProfile.Text = "Delete profile";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.AutoSize = true;
            this.buttonCreateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonCreateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCreateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCreateProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.buttonCreateProfile.Location = new System.Drawing.Point(353, 98);
            this.buttonCreateProfile.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCreateProfile.Size = new System.Drawing.Size(153, 27);
            this.buttonCreateProfile.TabIndex = 9;
            this.buttonCreateProfile.Text = "Create profile";
            this.buttonCreateProfile.UseVisualStyleBackColor = false;
            this.buttonCreateProfile.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBoxConfigs);
            this.panel4.Location = new System.Drawing.Point(30, 58);
            this.panel4.Margin = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 271);
            this.panel4.TabIndex = 1;
            // 
            // listBoxConfigs
            // 
            this.listBoxConfigs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.listBoxConfigs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxConfigs.FormattingEnabled = true;
            this.listBoxConfigs.ItemHeight = 16;
            this.listBoxConfigs.Location = new System.Drawing.Point(0, 0);
            this.listBoxConfigs.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxConfigs.Name = "listBoxConfigs";
            this.listBoxConfigs.Size = new System.Drawing.Size(302, 271);
            this.listBoxConfigs.Sorted = true;
            this.listBoxConfigs.TabIndex = 0;
            this.listBoxConfigs.SelectedIndexChanged += new System.EventHandler(this.listBoxConfigs_SelectedIndexChanged);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(164)))), ((int)(((byte)(165)))));
            this.panelTitle.Controls.Add(this.labelClosePorterControl);
            this.panelTitle.Controls.Add(this.label3);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(1, 4);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(542, 36);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // labelClosePorterControl
            // 
            this.labelClosePorterControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClosePorterControl.AutoSize = true;
            this.labelClosePorterControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosePorterControl.ForeColor = System.Drawing.Color.Silver;
            this.labelClosePorterControl.Location = new System.Drawing.Point(503, 5);
            this.labelClosePorterControl.Name = "labelClosePorterControl";
            this.labelClosePorterControl.Size = new System.Drawing.Size(33, 13);
            this.labelClosePorterControl.TabIndex = 1;
            this.labelClosePorterControl.Text = "Close";
            this.labelClosePorterControl.Click += new System.EventHandler(this.labelClosePorterControl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(25, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Porter - Configuration manager";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // ConfigManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 408);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigManager";
            this.Text = "ConfigManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Button buttonCreateProfile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxConfigs;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelClosePorterControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMakeActive;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label label1;
    }
}