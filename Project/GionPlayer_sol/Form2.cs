using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GionPlayer
{
    public partial class Form2 : Form
    {
        public string RadioName { get; set; }
        public string RadioURL { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            RadioName = NameBox.Text;
        }

        private void UrlBox_TextChanged(object sender, EventArgs e)
        {
            RadioURL = UrlBox.Text;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (RadioName != null && RadioURL != null)
            {
                this.Close();
            }
        }

        private void RadioLinks_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("http://streamurl.link");
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://streamurl.link",
                UseShellExecute = true
            });
        }
    }
}
