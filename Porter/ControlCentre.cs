using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IniParser;
using System.Net;

namespace Porter
{
    public partial class ControlCentre : Form
    {
        #region Service variables
        public string PorterPath = string.Empty;
        private ServerManager Servers = new ServerManager();

        Point initialLocation = new Point();
        public bool mouseDown = false;

        public bool? LastPHPServerState = null;
        public bool? LastMySQLServerState = null;

        FileIniDataParser parser;
        IniData parsedData;
        #endregion

        public ControlCentre(string[] args)
        {
            /// Not to be launched directly, but with launcher.
            /// Will have meaning in future versions.
            if (args.Count() == 0 || args[0] != "go")
            {
                MessageBox.Show("Please, use PorterLauncher.exe to launch Porter!");
                Environment.Exit(0);
            }

            InitializeComponent();
            this.PorterPath = Directory.GetCurrentDirectory().Replace('\\', '/');
            ServerStateUpdate();
            loadConfig();
        }

        void loadConfig()
        {
            parser = new FileIniDataParser();
            parser.RelaxedIniFormat = true;
            parsedData = parser.LoadFile(this.PorterPath + "/data/config.ini");
        }

        #region Button event handlers
        private void buttonPHPStartStopServer_Click(object sender, EventArgs e)
        {
            if (this.Servers.ProcessExists("PorterPhp"))
            {
                try
                {
                    this.Servers.KillPHPProcess("PorterPhp");
                    string[] tmpfiles = Directory.GetFiles(this.PorterPath + "/data/tmp");
                    foreach (string file in tmpfiles)
                    {
                        File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to stop PHP server - error: " + ex.Message);
                }
            }
            else
            {
                string PorterPhpPath = this.PorterPath + "/bin/php/PorterPhp.exe";
                try
                {
                    loadConfig();
                    string webport = parsedData.Sections["__global__section__"].GetKeyData("webport").Value;
                    string inifile = parsedData.Sections["ConfigurationProfiles"].GetKeyData("php").Value;
                    Servers.StartPHPProcess(PorterPhpPath, "-S 127.0.0.1:" + webport + " -t \"" + this.PorterPath + "\" -c \"" + this.PorterPath + "/data/php/" + inifile + ".ini\" -d extension_dir=\"" + this.PorterPath + "/bin/php/ext\" \"" + this.PorterPath + "/data/web/router.php\"", this.PorterPath + "/projects");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to start PHP server - error: " + ex.Message);
                }
            }
            ServerStateUpdate();
        }

        private void buttonMySQLStartStopServer_Click(object sender, EventArgs e)
        {
            if (this.Servers.ProcessExists("PorterMysqld"))
            {
                try
                {
                    this.Servers.StopMySQLProcess(this.PorterPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to stop MySQL server - error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    Servers.StartMySQLProcess(this.PorterPath, this.PorterPath + "/data/mysql/" + parsedData.Sections["ConfigurationProfiles"].GetKeyData("mysql").Value + ".ini");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to start MySQL server - error: " + ex.Message);
                }
            }
            ServerStateUpdate();
        }

        private void buttonPHPOpenBrowser_Click(object sender, EventArgs e)
        {
            Process Browser = new Process();
            Browser.StartInfo.FileName = "http://localhost";
            Browser.Start();
        }

        private void buttonManageProjects_Click(object sender, EventArgs e)
        {
            ProjectManager manager = new ProjectManager();
            manager.Show();
        }

        private void buttonStartGitConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Process git = new Process();
                git.StartInfo.WorkingDirectory = this.PorterPath + "/projects";
                git.StartInfo.FileName = this.PorterPath + "/bin/git/Git Bash.vbs";
                git.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GIT launch error: " + ex.Message);
            }
        }

        #endregion

        #region Form movement handlers
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
        #endregion

        #region Utils and misc event handlers
        /// This will disable statuss check when control center is minimised to free up some resources.
        private void ControlCentre_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                timerProcessStatussCheck.Stop();
            }
            else
            {
                timerProcessStatussCheck.Start();
            }
        }


        private void ServerStateUpdate()
        {
            bool PHPServerState = this.Servers.ProcessExists("PorterPhp");
            if (LastPHPServerState == null || (PHPServerState != this.LastPHPServerState))
            {
                if (PHPServerState)
                {
                    panelServersPhpState.BackColor = Color.FromArgb(0, 150, 0);
                    labelServersPhpState.Text = "PHP server is online";
                    labelServersPhpState.ForeColor = Color.FromArgb(0, 150, 0);
                    buttonPHPStartStopServer.Text = "Stop";
                }
                else
                {
                    panelServersPhpState.BackColor = Color.FromArgb(150, 0, 0);
                    labelServersPhpState.Text = "PHP server is offline";
                    labelServersPhpState.ForeColor = Color.FromArgb(150, 0, 0);
                    buttonPHPStartStopServer.Text = "Start";
                }
            }

            bool MySQLServerState = this.Servers.ProcessExists("PorterMysqld");
            if (LastMySQLServerState == null || (MySQLServerState != this.LastMySQLServerState))
            {
                if (MySQLServerState)
                {
                    panelServersMySQLState.BackColor = Color.FromArgb(0, 150, 0);
                    labelServersMySQLState.Text = "MySQL server is online";
                    labelServersMySQLState.ForeColor = Color.FromArgb(0, 150, 0);
                    buttonMySQLStartStopServer.Text = "Stop";
                }
                else
                {
                    panelServersMySQLState.BackColor = Color.FromArgb(150, 0, 0);
                    labelServersMySQLState.Text = "MySQL server is offline";
                    labelServersMySQLState.ForeColor = Color.FromArgb(150, 0, 0);
                    buttonMySQLStartStopServer.Text = "Start";
                }
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void timerProcessStatussCheck_Tick(object sender, EventArgs e)
        {
            ServerStateUpdate();
        }

        private void labelClosePorterControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelHidePorterControl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void buttonPHPOpenExplorer_Click(object sender, EventArgs e)
        {
            Process explorer = new Process();
            explorer.StartInfo.FileName = this.PorterPath + "/projects";
            explorer.Start();
        }

        private void buttonConfigurePhp_Click(object sender, EventArgs e)
        {
            ConfigManager manager = new ConfigManager("php");
            manager.Show();
        }

        private void buttonConfigureMySQL_Click(object sender, EventArgs e)
        {
            ConfigManager manager = new ConfigManager("mysql");
            manager.Show();
        }
        #endregion

        #region External applications
        private void buttonNode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choose javascript file for Node:";
            dialog.InitialDirectory = this.PorterPath + "projects/";
            dialog.Filter = "Node.js Javascript file|*.js";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Process node = new Process();
                    node.StartInfo.FileName = this.PorterPath + "/bin/node/node.exe";
                    node.StartInfo.Arguments = " \"" + dialog.FileName + "\"";
                    node.Start();
                }
                catch (Exception nodex)
                {
                    MessageBox.Show(nodex.Message);
                }
            }
        }

        private void buttonMySQLStartConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Process console = new Process();
                console.StartInfo.FileName = this.PorterPath + "/bin/mysql/bin/mysql.exe";
                console.StartInfo.Arguments = "-u root -p";
                console.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonHeidiSQLStart_Click(object sender, EventArgs e)
        {
            try
            {
                Process heidi = new Process();
                heidi.StartInfo.FileName = this.PorterPath + "/bin/heidisql/heidisql.exe";
                heidi.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonOpenFileZilla_Click(object sender, EventArgs e)
        {
            try
            {
                Process explorer = new Process();
                explorer.StartInfo.FileName = this.PorterPath + "/bin/filezilla/FileZillaPortable.exe";
                explorer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion

        #region Version info and updater
        private void labelComponentVersions_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine + Environment.NewLine;
            string message = "Porter v" + Application.ProductVersion + " Copyright (c) 2011-2012 LIT Software, Matiss Roberts Treinis and others." + NL +
                "PHP v" + FileVersionInfo.GetVersionInfo(this.PorterPath + "/bin/php/PorterPhp.exe").FileVersion + " Copyright (c) 1999 - 2012 The PHP Group." + NL +
                "MySQL v" + SVVersion(this.PorterPath + "/bin/mysql/bin/mysql.exe") + " Copyright (c) 2000, 2012, Oracle and/or its affiliates." + NL +
                "GIT v" + SVVersion(this.PorterPath + "/bin/git/bin/git.exe") + " Copyright (c) 2005 - 2012 Linus Torvalds & others" + NL +
                "Node.JS v" + FileVersionInfo.GetVersionInfo(this.PorterPath + "/bin/node/node.exe").FileVersion + " Copyright (C) Joyent, Inc. and other Node contributors." + NL +
                "HeidiSQL v" + FileVersionInfo.GetVersionInfo(this.PorterPath + "/bin/heidisql/heidisql.exe").FileVersion + " Copyright (C) 2000 - 2012 - Ansgar Becker" + NL +
                "FileZilla Portable v" + FileVersionInfo.GetVersionInfo(this.PorterPath + "/bin/filezilla/FileZillaPortable.exe").FileVersion + " Copyright (C) 2001 - 2012 - Tim Kosse, John T. Haller" + NL;
            MessageBox.Show(message, "Porter component versions");
        }

        public string SVVersion(string path)
        {
            Process mysqlv = new Process();
            mysqlv.StartInfo.FileName = path;
            mysqlv.StartInfo.Arguments = " --version";
            mysqlv.StartInfo.UseShellExecute = false;
            mysqlv.StartInfo.RedirectStandardOutput = true;
            mysqlv.StartInfo.CreateNoWindow = true;
            mysqlv.Start();
            string version = mysqlv.StandardOutput.ReadToEnd();
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(version, @"[0-9]{1}.[0-9]{1}.[0-9]{1,}", System.Text.RegularExpressions.RegexOptions.None);
            return match.Value;
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            PorterConf conf = new PorterConf();
            conf.Show();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            Process helpExp = new Process();
            helpExp.StartInfo.FileName = "http://litporter.sourceforge.net/";
            helpExp.Start();
        }

        private void labelCheckUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                int webVersion = Convert.ToInt32(client.DownloadString("http://litporter.sourceforge.net/version.of"));
                int localVersion = 0515;
                if (webVersion > localVersion)
                {
                    DialogResult res = MessageBox.Show("Update to version n" + webVersion + " available! Open home page?", "Update available", MessageBoxButtons.YesNo);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        Process helpExp = new Process();
                        helpExp.StartInfo.FileName = "http://litporter.sourceforge.net/update.php?version=" + localVersion;
                        helpExp.Start();
                    }
                }
                else
                {
                    MessageBox.Show("No update available!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
