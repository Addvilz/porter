using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Porter
{
    public partial class ConfEditor : Form
    {
        string efile = null;
        public ConfEditor(string file,string title)
        {
            InitializeComponent();
            efile = file;
            this.Text = title + " - " +this.Text;
            try
            {
                StreamReader reader = new StreamReader(file);
                textbox.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter w = new StreamWriter(efile);
                w.Write(textbox.Text);
                w.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
