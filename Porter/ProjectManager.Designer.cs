namespace Porter
{
    partial class ProjectManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManager));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelClosePorterControl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.buttonCloneProject = new System.Windows.Forms.Button();
            this.buttonCreateWithFramework = new System.Windows.Forms.Button();
            this.buttonCreateFromGit = new System.Windows.Forms.Button();
            this.buttonCreateEmptyProject = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(529, 36);
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
            this.labelClosePorterControl.Location = new System.Drawing.Point(490, 5);
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
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Porter - Project manager";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.buttonDeleteProject);
            this.panel1.Controls.Add(this.buttonCloneProject);
            this.panel1.Controls.Add(this.buttonCreateWithFramework);
            this.panel1.Controls.Add(this.buttonCreateFromGit);
            this.panel1.Controls.Add(this.buttonCreateEmptyProject);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 457);
            this.panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.progressBar.Location = new System.Drawing.Point(353, 404);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(153, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 14;
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.AutoSize = true;
            this.buttonDeleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteProject.Enabled = false;
            this.buttonDeleteProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonDeleteProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonDeleteProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonDeleteProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteProject.Location = new System.Drawing.Point(353, 184);
            this.buttonDeleteProject.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Padding = new System.Windows.Forms.Padding(1);
            this.buttonDeleteProject.Size = new System.Drawing.Size(153, 27);
            this.buttonDeleteProject.TabIndex = 13;
            this.buttonDeleteProject.Text = "Delete project";
            this.buttonDeleteProject.UseVisualStyleBackColor = false;
            this.buttonDeleteProject.Click += new System.EventHandler(this.buttonDeleteProject_Click);
            // 
            // buttonCloneProject
            // 
            this.buttonCloneProject.AutoSize = true;
            this.buttonCloneProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonCloneProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloneProject.Enabled = false;
            this.buttonCloneProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonCloneProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCloneProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonCloneProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloneProject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCloneProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.buttonCloneProject.Location = new System.Drawing.Point(353, 144);
            this.buttonCloneProject.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonCloneProject.Name = "buttonCloneProject";
            this.buttonCloneProject.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCloneProject.Size = new System.Drawing.Size(153, 27);
            this.buttonCloneProject.TabIndex = 12;
            this.buttonCloneProject.Text = "Clone project";
            this.buttonCloneProject.UseVisualStyleBackColor = false;
            this.buttonCloneProject.Click += new System.EventHandler(this.buttonCloneProject_Click);
            // 
            // buttonCreateWithFramework
            // 
            this.buttonCreateWithFramework.AutoSize = true;
            this.buttonCreateWithFramework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonCreateWithFramework.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateWithFramework.Enabled = false;
            this.buttonCreateWithFramework.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonCreateWithFramework.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCreateWithFramework.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonCreateWithFramework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateWithFramework.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCreateWithFramework.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.buttonCreateWithFramework.Location = new System.Drawing.Point(353, 104);
            this.buttonCreateWithFramework.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonCreateWithFramework.Name = "buttonCreateWithFramework";
            this.buttonCreateWithFramework.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCreateWithFramework.Size = new System.Drawing.Size(153, 27);
            this.buttonCreateWithFramework.TabIndex = 11;
            this.buttonCreateWithFramework.Text = "Setup framework";
            this.buttonCreateWithFramework.UseVisualStyleBackColor = false;
            this.buttonCreateWithFramework.Click += new System.EventHandler(this.buttonCreateWithFramework_Click);
            // 
            // buttonCreateFromGit
            // 
            this.buttonCreateFromGit.AutoSize = true;
            this.buttonCreateFromGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonCreateFromGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateFromGit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonCreateFromGit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCreateFromGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonCreateFromGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateFromGit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCreateFromGit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.buttonCreateFromGit.Location = new System.Drawing.Point(353, 64);
            this.buttonCreateFromGit.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonCreateFromGit.Name = "buttonCreateFromGit";
            this.buttonCreateFromGit.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCreateFromGit.Size = new System.Drawing.Size(153, 27);
            this.buttonCreateFromGit.TabIndex = 10;
            this.buttonCreateFromGit.Text = "Create from GIT";
            this.buttonCreateFromGit.UseVisualStyleBackColor = false;
            this.buttonCreateFromGit.Click += new System.EventHandler(this.buttonCreateFromGit_Click);
            // 
            // buttonCreateEmptyProject
            // 
            this.buttonCreateEmptyProject.AutoSize = true;
            this.buttonCreateEmptyProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonCreateEmptyProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateEmptyProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonCreateEmptyProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCreateEmptyProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonCreateEmptyProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateEmptyProject.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonCreateEmptyProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.buttonCreateEmptyProject.Location = new System.Drawing.Point(353, 24);
            this.buttonCreateEmptyProject.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.buttonCreateEmptyProject.Name = "buttonCreateEmptyProject";
            this.buttonCreateEmptyProject.Padding = new System.Windows.Forms.Padding(1);
            this.buttonCreateEmptyProject.Size = new System.Drawing.Size(153, 27);
            this.buttonCreateEmptyProject.TabIndex = 9;
            this.buttonCreateEmptyProject.Text = "Create empty";
            this.buttonCreateEmptyProject.UseVisualStyleBackColor = false;
            this.buttonCreateEmptyProject.Click += new System.EventHandler(this.buttonCreateEmptyProject_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBoxProjects);
            this.panel4.Location = new System.Drawing.Point(30, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 404);
            this.panel4.TabIndex = 1;
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.listBoxProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 16;
            this.listBoxProjects.Location = new System.Drawing.Point(0, 0);
            this.listBoxProjects.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(302, 404);
            this.listBoxProjects.Sorted = true;
            this.listBoxProjects.TabIndex = 0;
            this.listBoxProjects.SelectedIndexChanged += new System.EventHandler(this.listBoxProjects_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 4);
            this.panel3.TabIndex = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 498);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelClosePorterControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCloneProject;
        private System.Windows.Forms.Button buttonCreateWithFramework;
        private System.Windows.Forms.Button buttonCreateFromGit;
        private System.Windows.Forms.Button buttonCreateEmptyProject;
        private System.Windows.Forms.Button buttonDeleteProject;
        private System.Windows.Forms.ProgressBar progressBar;

    }
}