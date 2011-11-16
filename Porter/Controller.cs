using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace Porter
{
    class Controller
    {
        #region Nginx server controller
        /// <summary>
        /// Start Nginx web server
        /// </summary>
        public void startNginx()
        {
            try
            {
                string place = System.Windows.Forms.Application.StartupPath + "\\nginx";
                Process proc = new Process();
                proc.StartInfo.FileName = place + "\\porternginx.exe";
                proc.StartInfo.WorkingDirectory = place;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not start Nginx web server. Check Your Nginx installation.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Stop Nginx web server
        /// </summary>
        public void stopNginx()
        {
            try
            {
                string place = System.Windows.Forms.Application.StartupPath + "\\nginx";
                Process proc = new Process();
                proc.StartInfo.FileName = place + "\\porternginx.exe";
                proc.StartInfo.Arguments = "-s stop";
                proc.StartInfo.WorkingDirectory = place;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Check if Nginx server is running
        /// </summary>
        /// <returns>true if running, false if not</returns>
        public bool checkNginx()
        {
            Process[] nginxWorkers = Process.GetProcessesByName("porternginx");
            if (nginxWorkers.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Restart Nginx web server
        /// </summary>
        public void reloadNginx()
        {
            try
            {
                string place = System.Windows.Forms.Application.StartupPath + "\\nginx";
                Process proc = new Process();
                proc.StartInfo.FileName = place + "\\porternginx.exe";
                proc.StartInfo.Arguments = "-s reload";
                proc.StartInfo.WorkingDirectory = place;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region PHP-CGI deamon controller
        /// <summary>
        /// Starts PHP-CGI deamon
        /// </summary>
        public void startPHP()
        {
            try
            {
                string place = System.Windows.Forms.Application.StartupPath + "\\php";
                Process proc = new Process();
                proc.StartInfo.FileName = place + "\\porter-php-cgi.exe";
                proc.StartInfo.Arguments = " -c \"" + place + "\\php.ini\" -b 127.0.0.1:19005 -d extension_dir=\"" + place + "\\ext\"";
                System.Diagnostics.Debug.WriteLine(proc.StartInfo.Arguments);
                proc.StartInfo.WorkingDirectory = place;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not start PHP-CGI. Check Your PHP-CGI installation.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Checks if PHP-CGI deamon is running
        /// </summary>
        /// <returns>true if running, false if not</returns>
        public bool checkPhp()
        {
            Process[] phpWorkers = Process.GetProcessesByName("porter-php-cgi");
            if (phpWorkers.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Stops PHP-CGI deamons
        /// </summary>
        public void stopPhp()
        {
            try
            {
                Process[] phpWorkers = Process.GetProcessesByName("porter-php-cgi");
                foreach (Process phpWorker in phpWorkers)
                {
                    phpWorker.Kill();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MySQL deamon controller
        /// <summary>
        /// Starts MySQL deamon
        /// </summary>
        public void startMysql()
        {
            try
            {
                string place = System.Windows.Forms.Application.StartupPath + "\\mysql";
                Process proc = new Process();
                proc.StartInfo.FileName = place + "\\bin\\porter-mysqld.exe";
                proc.StartInfo.WorkingDirectory = place;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not start MySQL. Check Your MySQL installation.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Stops MySQL deamon
        /// </summary>
        public void stopMysql()
        {
            try
            {
                string place = System.Windows.Forms.Application.StartupPath + "\\mysql";
                Process proc = new Process();
                proc.StartInfo.FileName = place + "\\bin\\mysqladmin.exe";
                proc.StartInfo.Arguments = "-u porter shutdown";
                proc.StartInfo.WorkingDirectory = place;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not stop MySQL. Check Your MySQL installation.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if MySQL deamon is running. 
        /// </summary>
        /// <returns>true if running, false if not</returns>
        public bool checkMysql()
        {
            Process[] phpWorkers = Process.GetProcessesByName("porter-mysqld");
            if (phpWorkers.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
