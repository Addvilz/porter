using System.Diagnostics;
using System.Linq;

namespace Porter
{
    class ServerManager
    {
        /// <summary>
        /// Check, if process is running
        /// </summary>
        /// <param name="Name">Process name</param>
        /// <returns>true, if running, false if not</returns>
        public bool ProcessExists(string Name)
        {
            Process[] ProcessList = Process.GetProcessesByName(Name);
            if (ProcessList.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool StartPHPProcess(string Path, string Arguments, string CWD)
        {
            Process eProcess = new Process();
            eProcess.StartInfo.FileName = Path;
            eProcess.StartInfo.Arguments = Arguments;
            eProcess.StartInfo.CreateNoWindow = true;
            eProcess.StartInfo.UseShellExecute = true;
            eProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            eProcess.StartInfo.WorkingDirectory = CWD;
            return eProcess.Start();
        }

        public void KillPHPProcess(string Name)
        {
            Process[] ProcessList = Process.GetProcessesByName(Name);
            foreach (Process proc in ProcessList)
            {
                proc.Kill();
            }
        }

        public bool StartMySQLProcess(string Path, string ini)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = Path + "/bin/mysql/bin/PorterMysqld.exe";
            proc.StartInfo.WorkingDirectory = Path + "/bin/mysql/";
            proc.StartInfo.Arguments = "--defaults-file=\"" + ini + "\" --basedir=\"" + Path + "/bin/mysql\"  --datadir=\"" + Path + "/bin/mysql/data\"";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            return proc.Start();
        }

        public bool StopMySQLProcess(string Path)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = Path + "/bin/mysql/bin/mysqladmin.exe";
            proc.StartInfo.Arguments = "-u porter shutdown";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            return proc.Start();
        }
    }
}
