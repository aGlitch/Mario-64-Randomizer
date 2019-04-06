using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario64Randomizer
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }
        private void AboutDialog_Load(object sender, System.EventArgs e)
        {
            llblGithub.Links.Add(0, 29, "https://github.com/aGlitch/Mario-64-Randomizer");
        }

        private void llblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aGlitch/Mario-64-Randomizer");
        }
    }
}
