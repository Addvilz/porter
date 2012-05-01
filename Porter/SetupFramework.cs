using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Porter
{
    public partial class SetupFramework : Form
    {
        string PorterPath = string.Empty;
        Dictionary<string, string> frames = new Dictionary<string, string>();
        string Project = null;

        Point initialLocation = new Point();
        public bool mouseDown = false;

        public SetupFramework(string project)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Project = project;
            PorterPath = Directory.GetCurrentDirectory().Replace('\\', '/');
            StreamReader fdbReader = new StreamReader(PorterPath + "/data/framedb.of");
            string[] fdb = fdbReader.ReadToEnd().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string fdbentry in fdb){
                if (fdbentry.StartsWith("#") == false)
                {
                    string[] fdbentryparts = fdbentry.Split('=');
                    frames.Add(fdbentryparts[0], fdbentryparts[1]);
                    listBoxFrameworks.Items.Add(fdbentryparts[0]);
                }
            }

        }

        private void listBoxFrameworks_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSetup.Enabled = true;
        }

        private void labelClosePorterControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            string frame = listBoxFrameworks.SelectedItem.ToString();
            string giturl = frames[frame];
            try
            {
                Process git = new Process();
                git.StartInfo.WorkingDirectory = this.PorterPath + "/projects/"+Project+"/";
                git.StartInfo.FileName = this.PorterPath + "/bin/git/bin/git.exe";
                git.StartInfo.Arguments = "clone "+giturl;
                git.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
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
    }
}
