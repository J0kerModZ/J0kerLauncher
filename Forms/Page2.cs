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

namespace J0kerClient
{
    public partial class Page2 : Form
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://j0kermodz.lol");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            base.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("http://j0kermodz.lol");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/j0kermodz");
        }
    }
}
