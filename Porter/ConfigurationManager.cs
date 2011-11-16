using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Porter
{
    /// <summary>
    /// Portable configuration manager implementation for Porter
    /// </summary>
    class ConfigurationManager
    {
        /// <summary>
        /// Configuration buffer
        /// </summary>
        private Dictionary<string, string> conf = new Dictionary<string, string>();
        /// <summary>
        /// Load configuration from file to buffer
        /// </summary>
        public void load()
        {
            try
            {
                StreamReader r = new StreamReader("data/conf.of");
                string[] data = r.ReadToEnd().Split('\n');
                r.Close();
                foreach (string line in data)
                {
                    string tm = line.Trim();
                    if (tm != "")
                    {
                        string[] parts = tm.Split('=');
                        conf.Add(parts[0].Trim().ToLower(), parts[1].Trim().ToLower());
                    }
                }
            }
            catch(Exception ex)
            {
                StreamWriter logWriter = new StreamWriter("data/error.log", true);
                logWriter.WriteLine("Configuration error: " + ex.Message);
                logWriter.Close();
            }
        }

        /// <summary>
        /// Save configuration from buffer to file
        /// </summary>
        public void save()
        {
            StreamWriter w = new StreamWriter("data/conf.of");
            foreach (KeyValuePair<string, string> kvp in conf)
            {
                string line = kvp.Key.ToLower() + "=" + kvp.Value.ToLower();
                w.WriteLine(line);
            }
            w.Flush();
            w.Close();
        }

        /// <summary>
        /// Get value from configuration buffer
        /// </summary>
        /// <param name="key">Option key</param>
        /// <returns>Option value</returns>
        public string getValue(string key)
        {
            key = key.ToLower();
            if (conf.Keys.Contains(key))
            {
                return conf[key];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Set value in configuration buffer
        /// </summary>
        /// <param name="key">Option key</param>
        /// <param name="value">Option value</param>
        public void setValue(string key, string value)
        {
            key = key.ToLower();
            value = value.ToLower();
            if (conf.Keys.Contains(key))
            {
                conf[key] = value;
            }
            else
            {
                conf.Add(key,value);
            }
        }
    }
}
