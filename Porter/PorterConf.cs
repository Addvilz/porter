using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IniParser;

namespace Porter
{
    public partial class PorterConf : Form
    {
        string PorterPath = String.Empty;
        IniData data;
        FileIniDataParser parser;
        Point initialLocation = new Point();
        public bool mouseDown = false;

        public PorterConf()
        {
            InitializeComponent();
            this.PorterPath = Directory.GetCurrentDirectory().Replace('\\', '/');
            parser = new FileIniDataParser();
            parser.RelaxedIniFormat = true;
            data = parser.LoadFile(this.PorterPath + "/data/config.ini");
            webport.Text = data["__global__section__"]["webport"];
            allowip.Text = data["__global__section__"]["allowip"];
        }

        private void labelClosePorterControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           data["__global__section__"]["webport"] = webport.Text;
           data["__global__section__"]["allowip"] = allowip.Text;
           StreamWriter writer = new StreamWriter(this.PorterPath + "/data/config.ini");
           parser.WriteData(writer,data);
           writer.Close();
           this.Close();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            initialLocation = new Point(e.X, e.Y);
            mouseDown = true;
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Location = new Point(this.Left - (initialLocation.X - e.X), this.Top - (this.initialLocation.Y - e.Y));
            }
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
