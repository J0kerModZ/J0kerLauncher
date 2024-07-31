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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private static void ExecuteCommand(string command)
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            });
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

        private void button12_Click(object sender, EventArgs e)
        {
            Page2 pg2 = new Page2();
            pg2.Show();
            base.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // GTAG DOWNLOAD HERE
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/J0kerModZ/GorillaTag2DMenu/releases/tag/ModMenu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/J0kerModZ/J0ker-Client");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/J0kerModZ/Raldis_Crack_House_Menu/releases/tag/ModMenu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/J0kerModZ/Raldis_Crack_House_Menu/tree/main");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/J0kerModZ/GorillaTag2DMenu");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/j0kermodz");
        }
    }
}
