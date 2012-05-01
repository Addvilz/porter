using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Porter
{
    public partial class ConfigEditor : Form
    {
        string iniFile = string.Empty;
        public ConfigEditor(string file)
        {
            InitializeComponent();
            this.iniFile = file;
            loadFile();
            this.Top = Screen.GetWorkingArea(this).Top;
            this.Left = Screen.GetWorkingArea(this).Left;
            this.Width = Screen.GetWorkingArea(this).Width;
            this.Height = Screen.GetWorkingArea(this).Height;
        }

        private void loadFile()
        {
            StreamReader iniReader = new StreamReader(this.iniFile);
            richTextBoxIniText.Text = iniReader.ReadToEnd();
            iniReader.Close();

            string pattern = @"^\[[A-z0-9_-]+\]";
            Regex re = new Regex(pattern, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            listBoxIniSections.Items.Clear();
            MatchCollection matches = re.Matches(richTextBoxIniText.Text);
            for (int i = 0; i < matches.Count; i++)
            {
                listBoxIniSections.Items.Add(matches[i].Value);
            }
        }


        private void listBoxIniSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string key = listBoxIniSections.SelectedItem.ToString();
                int pos = richTextBoxIniText.Find(key);
                richTextBoxIniText.Select(pos, 0);
                richTextBoxIniText.ScrollToCaret();
            }
            catch { }
        }

        private void labelClosePorterControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(this.iniFile);
                writer.Write(richTextBoxIniText.Text);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadFile();
        }
    }
}
