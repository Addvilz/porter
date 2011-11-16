using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Porter
{
    public partial class PorterControl : Form
    {
        Controller ServerController;
        ConfigurationManager ConfigManager;
        string path = System.Windows.Forms.Application.StartupPath;

        #region Startup
        public PorterControl()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; ///I feel so dirty by doing this...
            ServerController = new Controller();
            ConfigManager = new ConfigurationManager();
            ConfigManager.load();
            stateUpdate();
            initUI();
            if (ConfigManager.getValue("updatecheck") == "true")
            {
                Thread t = new Thread(checkUpdates);
                t.Start();
            }
            else
            {
                updateAvailable.Text = "Porter v" + Application.ProductVersion;
                updateAvailable.Left = this.Width - updateAvailable.Width - 40;
            }
        }
        #endregion

        #region System init
        /// <summary>
        /// Stuff we need to check. Checks for server executables and disables controls if not present.
        /// </summary>
        public void initCheck()
        {
            List<string> errors = new List<string>();
            if (File.Exists(path + "\\nginx\\porternginx.exe") == false)
            {
                errors.Add("Could not find the executable for Nginx web server. Nginx will not be available.");
                buttonNginxStart.Visible = false;
                buttonNginxStop.Visible = false;
                buttonNginxReload.Visible = false;
                buttonNginxConfigure.Visible = false;
            }

            if (File.Exists(path + "\\php\\porter-php-cgi.exe") == false)
            {
                errors.Add("Could not find the executable for PHP-CGI. PHP will not be available.");
                buttonPHPStart.Visible = false;
                buttonPHPStop.Visible = false;
                buttonPHPReload.Visible = false;
                buttonPHPConfigure.Visible = false;
            }

            if (File.Exists(path + "\\mysql\\bin\\porter-mysqld.exe") == false)
            {
                errors.Add("Could not find the executable for MySQL. MySQL will not be available.");
                buttonMySQLStart.Visible = false;
                buttonMySQLStop.Visible = false;
                buttonMySQLReload.Visible = false;
                buttonMySQLConfigure.Visible = false;
            }
            ///To-do: more system checks?
            if (errors.Count != 0)
            {
                string message = null;
                foreach (string error in errors)
                {
                    message += " -" + error + Environment.NewLine;
                }
                if (errors.Count < 3)
                {
                    MessageBox.Show("Warning:" + Environment.NewLine + message + Environment.NewLine + "Some application features will be unavailiable!", "Troll in the dungeon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Fatal error:" + Environment.NewLine + message + Environment.NewLine + "None of the server instances could be found. Controller can not continue, .", "Troll in the dungeon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Loads UI related stuff and dynamic labels.
        /// </summary>
        void initUI()
        {
            labelPorterVersion.Text = "v" + Application.ProductVersion;
            checkBoxCheckForUpdates.Checked = Convert.ToBoolean(ConfigManager.getValue("updatecheck"));
            checkBoxCheckAvailiablePorts.Checked = Convert.ToBoolean(ConfigManager.getValue("portscheck"));
        }
        #endregion

        #region State controllers
        /// <summary>
        /// Monitors server state
        /// </summary>
        private void watchdog_Tick(object sender, EventArgs e)
        {
            stateUpdate();  
        }

        /// <summary>
        /// Update of server state in UI
        /// </summary>
        void stateUpdate()
        {
            if (ServerController.checkNginx() == true)
            {
                labelNginxState.Text = "Running";
                labelNginxState.ForeColor = Color.Green;
                buttonNginxStart.Enabled = false;
                buttonNginxStop.Enabled = true;
                buttonNginxReload.Enabled = true;
            }
            else
            {
                labelNginxState.Text = "Stopped";
                labelNginxState.ForeColor = Color.Red;
                buttonNginxStart.Enabled = true;
                buttonNginxStop.Enabled = false;
                buttonNginxReload.Enabled = false;
            }

            if (ServerController.checkPhp() == true)
            {
                labelPHPState.Text = "Running";
                labelPHPState.ForeColor = Color.Green;
                buttonPHPStart.Enabled = false;
                buttonPHPStop.Enabled = true;
                buttonPHPReload.Enabled = true;
            }
            else
            {
                labelPHPState.Text = "Stopped";
                labelPHPState.ForeColor = Color.Red;
                buttonPHPStart.Enabled = true;
                buttonPHPStop.Enabled = false;
                buttonPHPReload.Enabled = false;
            }

            if (ServerController.checkMysql() == true)
            {
                labelMySQLState.Text = "Running";
                labelMySQLState.ForeColor = Color.Green;
                buttonMySQLStart.Enabled = false;
                buttonMySQLStop.Enabled = true;
                buttonMySQLReload.Enabled = true;
            }
            else
            {
                labelMySQLState.Text = "Stopped";
                labelMySQLState.ForeColor = Color.Red;
                buttonMySQLStart.Enabled = true;
                buttonMySQLStop.Enabled = false;
                buttonMySQLReload.Enabled = false;
            }
        }
        #endregion

        #region Nginx control event handlers
        private void buttonStartNginx_Click(object sender, EventArgs e)
        {
            if (checkBoxCheckAvailiablePorts.Checked == false || Utils.portCheck(80) == true)
            {
                ServerController.startNginx();
                stateUpdate();
            }
            else
            {
                MessageBox.Show("Can not start Nginx Web server- port 80 is in use by another program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonStopNginx_Click(object sender, EventArgs e)
        {
            ServerController.stopNginx();
            stateUpdate();
        }

        private void buttonReloadNginx_Click(object sender, EventArgs e)
        {
            labelNginxState.Text = "Reloading";
            labelNginxState.ForeColor = Color.Yellow;
            ServerController.reloadNginx();
        }

        private void buttonNginxConfigure_Click(object sender, EventArgs e)
        {
            ConfEditor editor = new ConfEditor(System.Windows.Forms.Application.StartupPath + "\\nginx\\conf\\nginx.conf","Nginx");
            editor.Show();
        }
        #endregion

        #region PHP control event handlers
        private void buttonStartPhp_Click(object sender, EventArgs e)
        {
            if (checkBoxCheckAvailiablePorts.Checked == false || Utils.portCheck(1939) == true)
            {
                ServerController.startPHP();
                stateUpdate();
            }
            else
            {
                MessageBox.Show("Can not start PHP-CGI deamon- port 19005 is in use by another program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonStopPHP_Click(object sender, EventArgs e)
        {
            ServerController.stopPhp();
            stateUpdate();
        }

        private void buttonPHPReload_Click(object sender, EventArgs e)
        {
            labelPHPState.Text = "Reloading";
            labelPHPState.ForeColor = Color.Yellow;
            ServerController.stopPhp();
            ServerController.startPHP();
            stateUpdate();
        }

        private void buttonPHPConfigure_Click(object sender, EventArgs e)
        {
            ConfEditor editor = new ConfEditor(System.Windows.Forms.Application.StartupPath + "\\php\\php.ini", "PHP");
            editor.Show();
        }
        #endregion

        #region MySQL control event handlers
        private void buttonMySQLStart_Click(object sender, EventArgs e)
        {
            if (checkBoxCheckAvailiablePorts.Checked == false || Utils.portCheck(3306) == true)
            {
                ServerController.startMysql();
                stateUpdate();
            }
            else
            {
                MessageBox.Show("Can not start MySQL deamon- port 3306 is in use by another program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonMySQLStop_Click(object sender, EventArgs e)
        {
            ServerController.stopMysql();
            stateUpdate();
        }

        private void buttonMySQLReload_Click(object sender, EventArgs e)
        {
            labelMySQLState.Text = "Reloading";
            labelMySQLState.ForeColor = Color.Orange;
            ServerController.stopMysql();
            ServerController.startMysql();
            stateUpdate();
        }

        private void buttonMySQLConfigure_Click(object sender, EventArgs e)
        {
            ConfEditor editor = new ConfEditor(System.Windows.Forms.Application.StartupPath + "\\mysql\\my.ini", "MySQL");
            editor.Show();
        }
        #endregion

        #region System updater
        ///To-do: automatic update?

        /// <summary>
        /// Checks for update online.
        /// </summary>
        /// <returns>boolean true on new version, false if no updates avilable</returns>
        bool check()
        {
            bool state = false;
            try
            {
                StreamReader reader = new StreamReader("data/version.of");
                string localVersion = reader.ReadToEnd();
                reader.Close();
                WebClient client = new WebClient();
                string remoteVersion = client.DownloadString("http://porter.lit.lv/updates/version.of");
                if (Convert.ToInt32(remoteVersion) > Convert.ToInt32(localVersion))
                {
                    state = true;
                }
                else
                {
                    state = false;
                }
            }
            catch (WebException ex)
            {
                StreamWriter logWriter = new StreamWriter("data/error.log", true);
                logWriter.WriteLine("Updater error: " + ex.Message);
                state = false;
                logWriter.Close();
            }
            return state;
        }

        /// <summary>
        /// Updates controller
        /// </summary>
        void checkUpdates()
        {
            if (check() == false)
            {
                updateAvailable.Text = "Porter v" + Application.ProductVersion;
                updateAvailable.Enabled = false;
                updateAvailable.Left = this.Width - updateAvailable.Width - 40;
            }
            else
            {
                updateAvailable.Text = "Update available!";
                updateAvailable.Enabled = true;
                updateAvailable.Left = this.Width - updateAvailable.Width - 40;
            }
        }

        private void updateAvailable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://porter.lit.lv/update.php?version=" + Application.ProductVersion);
        }
        #endregion

        #region Porter UI and other related tasks
        private void PorterNotify_MouseClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void PorterControl_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Visible = false;
            }
        }
        #endregion

        #region Event handlers for other controls
        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            if (ServerController.checkNginx() == false && buttonNginxStart.Visible == true)
            {
                ServerController.startNginx();
            }
            if (ServerController.checkPhp() == false && buttonPHPStart.Visible == true)
            {
                ServerController.startPHP();
            }
            if (ServerController.checkMysql() == false && buttonMySQLStart.Visible == true)
            {
                ServerController.startMysql();
            }
            stateUpdate();
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            if (ServerController.checkNginx() && buttonNginxStart.Visible == true)
            {
                ServerController.stopNginx();
            }
            if (ServerController.checkPhp() && buttonPHPStart.Visible == true)
            {
                ServerController.stopPhp();
            }
            if (ServerController.checkMysql() && buttonMySQLStart.Visible == true)
            {
                ServerController.stopMysql();
            }
            stateUpdate();
        }

        private void buttonReloadAll_Click(object sender, EventArgs e)
        {
            if (ServerController.checkNginx())
            {
                labelNginxState.Text = "Reloading";
                labelNginxState.ForeColor = Color.Yellow;
                ServerController.reloadNginx();
            }
            if (ServerController.checkPhp())
            {
                labelPHPState.Text = "Reloading";
                labelPHPState.ForeColor = Color.Yellow;
                ServerController.stopPhp();
                ServerController.startPHP();
            }
            if (ServerController.checkMysql())
            {
                labelMySQLState.Text = "Reloading";
                labelMySQLState.ForeColor = Color.Yellow;
                ServerController.stopMysql();
                ServerController.startMysql();
            }
        }

        private void buttonHtdocsOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", path + "\\nginx\\htdocs");
        }
    
        private void linkLabelPorterHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelPorterHome.Text);
        }
        #endregion

        #region System settings event handlers
        private void checkBoxCheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            ConfigManager.setValue("updatecheck",checkBoxCheckForUpdates.Checked.ToString());
            ConfigManager.save();
        }

        private void checkBoxCheckAvailiablePorts_CheckedChanged(object sender, EventArgs e)
        {
            ConfigManager.setValue("portscheck", checkBoxCheckAvailiablePorts.Checked.ToString());
            ConfigManager.save();
        }

        private void richTextBoxLicenseInfo_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/litporter/");
        }
        #endregion
    }
}
