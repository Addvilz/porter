using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IniParser;

namespace Porter
{

    public partial class ConfigManager : Form
    {
        string config = string.Empty;
        string PorterPath = string.Empty;
        FileIniDataParser parser;
        IniData parsedData;

        Point initialLocation = new Point();
        public bool mouseDown = false;

        public ConfigManager(string configProf)
        {
            InitializeComponent();
            this.config = configProf;
            this.PorterPath = Directory.GetCurrentDirectory().Replace('\\', '/');
            parser = new FileIniDataParser();
            parser.RelaxedIniFormat = true;
            parsedData = parser.LoadFile(this.PorterPath + "/data/config.ini");
            labelActive.Text = parsedData.Sections["ConfigurationProfiles"].GetKeyData(config).Value;
            loadList();
        }

        public void loadList()
        {
            listBoxConfigs.Items.Clear();
            string[] inifiles = Directory.GetFiles(this.PorterPath + "/data/" + config);
            foreach (string file in inifiles)
            {
                listBoxConfigs.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            if (listBoxConfigs.Items.Count > 0)
            {
                listBoxConfigs.SetSelected(0, true);
            }
        }

        private void labelClosePorterControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonMakeActive.Enabled = true;
            buttonEditProfile.Enabled = true;
            buttonDeleteProfile.Enabled = true;
        }

        private void buttonMakeActive_Click(object sender, EventArgs e)
        {
            KeyData data = new KeyData(config);
            data.Value = listBoxConfigs.SelectedItem.ToString();
            labelActive.Text = data.Value;
            parsedData.Sections["ConfigurationProfiles"].SetKeyData(data);
            parser.SaveFile(this.PorterPath + "/data/config.ini", parsedData);
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            string file = this.PorterPath + "/data/" + config + "/" + listBoxConfigs.SelectedItem.ToString() + ".ini";
            ConfigEditor editor = new ConfigEditor(file);
            editor.Show();
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            string res = null;
            if (InputDialog.InputBox("Enter the name of the profile [A-z0-9_.-]:", ref res, true) == System.Windows.Forms.DialogResult.OK)
            {
                if (res == string.Empty)
                {
                    MessageBox.Show("Profile name can not be empty!");
                }
                else if (File.Exists(this.PorterPath + "/data/" + config + "/" + res + ".ini") == false)
                {
                    try
                    {
                        File.Create(this.PorterPath + "/data/" + config + "/" + res + ".ini");
                        loadList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating profile: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Error: profile with this name already exists!");
                }
            }
        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure?", "Confirm deletion", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string file = this.PorterPath + "/data/" + config + "/" + listBoxConfigs.SelectedItem.ToString() + ".ini";
                try
                {
                    File.Delete(file);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                loadList();
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
