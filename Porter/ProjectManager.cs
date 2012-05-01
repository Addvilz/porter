using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Porter
{
    public partial class ProjectManager : Form
    {
        string PorterPath;

        Point initialLocation = new Point();
        public bool mouseDown = false;

        public ProjectManager()
        {
            InitializeComponent();
            this.PorterPath = Directory.GetCurrentDirectory().Replace('\\', '/');
            populateDirs();
            progressBar.MarqueeAnimationSpeed = 100;
        }

        void populateDirs()
        {
            listBoxProjects.Items.Clear();
            string[] dirs = Directory.GetDirectories(this.PorterPath + "/projects");
            foreach (string dir in dirs)
            {
                string name = Path.GetFileName(dir);
                listBoxProjects.Items.Add(name);
            }

            if (listBoxProjects.Items.Count > 0)
            {
                listBoxProjects.SetSelected(0, true);
            }
        }

        private void labelClosePorterControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateEmptyProject_Click(object sender, EventArgs e)
        {
            string res = null;
            if (InputDialog.InputBox("Enter the name of the project [A-z0-9_.-]:", ref res, true) == System.Windows.Forms.DialogResult.OK)
            {
                if (res == string.Empty)
                {
                    MessageBox.Show("Project name can not be empty!");
                }
                else if (Directory.Exists(this.PorterPath + "/projects/" + res) == false)
                {
                    try
                    {
                        Directory.CreateDirectory(this.PorterPath + "/projects/" + res);
                        populateDirs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating project: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Error: project with this name already exists!");
                }
            }
        }

        private void buttonCreateFromGit_Click(object sender, EventArgs e)
        {
            string res = null;
            if (InputDialog.InputBox("Enter the name of the project [A-z0-9_.-]:", ref res, true) == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(this.PorterPath + "/projects/" + res) == false)
                {
                    try
                    {
                        Directory.CreateDirectory(this.PorterPath + "/projects/" + res);

                        string giturl = null;
                        if (InputDialog.InputBox("Enter the URL of the GIT repository (make sure, it is valid):", ref giturl, false) == System.Windows.Forms.DialogResult.OK)
                        {
                            Process proc = new Process();
                            proc.StartInfo.FileName = this.PorterPath + "/bin/git/bin/git.exe";
                            proc.StartInfo.Arguments = "clone " + giturl;
                            proc.StartInfo.WorkingDirectory = this.PorterPath + "/projects/" + res;
                            proc.Start();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating project: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Error: project with this name already exists!");
                }
            }
        }

        private void buttonCreateWithFramework_Click(object sender, EventArgs e)
        {
            string project = listBoxProjects.SelectedItem.ToString();
            SetupFramework frame = new SetupFramework(project);
            frame.Show();
        }

        private void listBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCloneProject.Enabled = true;
            buttonDeleteProject.Enabled = true;
            buttonCreateWithFramework.Enabled = true;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            initialLocation = new Point(e.X, e.Y);
            mouseDown = true;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Location = new Point(this.Left - (initialLocation.X - e.X), this.Top - (this.initialLocation.Y - e.Y));
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonCloneProject_Click(object sender, EventArgs e)
        {
            string project = listBoxProjects.SelectedItem.ToString();
            string res = null;
            if (InputDialog.InputBox("Enter the name of the NEW project [A-z0-9_.-]:", ref res, true) == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(this.PorterPath + "/projects/" + res) == false)
                {
                    try
                    {
                        Directory.CreateDirectory(this.PorterPath + "/projects/" + res);
                        string[] dirList = Directory.GetDirectories(this.PorterPath + "/projects/" + project, "*", SearchOption.AllDirectories);
                        string[] fileList = Directory.GetFiles(this.PorterPath + "/projects/" + project, "*.*", SearchOption.AllDirectories);
                        progressBar.Maximum = dirList.Count() + fileList.Count();
                        foreach (string dirPath in dirList)
                        {
                            Directory.CreateDirectory(dirPath.Replace(this.PorterPath + "/projects/" + project, this.PorterPath + "/projects/" + res));
                            progressBar.PerformStep();
                        }
                        foreach (string newPath in fileList)
                        {
                            File.Copy(newPath, newPath.Replace(this.PorterPath + "/projects/" + project, this.PorterPath + "/projects/" + res));
                            progressBar.PerformStep();
                        }
                        progressBar.Value = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating project: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Error: project with this name already exists!");
                }
            }
        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            string res = null;
            string project = listBoxProjects.SelectedItem.ToString();
            if (InputDialog.InputBox("ARE YOU SURE?! Enter 'confirm' to delete '" + project + "':", ref res, true) == System.Windows.Forms.DialogResult.OK)
            {
                if (res == "confirm" && project != "")
                {
                    try
                    {
                        Directory.Delete(this.PorterPath + "/projects/" + project, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting project: " + ex.Message);
                    }
                }
            }
            populateDirs();
        }

    }
}
