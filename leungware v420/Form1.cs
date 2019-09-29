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

namespace leungware_v420
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("i dont know how to code");
            InitializeComponent();
        }

        private void HenryHomhoClick(object sender, EventArgs e)
        {
            // opens up a form that legit only opens chrome
            MessageBox.Show("useless af why are you looking here");
            MessageBox.Show("or is it?");
            var leungWareToolBoard = new LeungWareToolBoard();
            leungWareToolBoard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // opens the url (the source code to this mess)
            Process.Start("https://github.com/rethinkingrn/leungware");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // opens the placebo part (nothing acutally works here)
            MessageBox.Show("sksksksksksksksksksksksksksksk");
            var placebo = new PLACEBO();
            placebo.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
