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
        // A new boolean value that is whether button2 has been clicked.
        public bool Button2HasBeenClicked = false;
        public Placebo()
        {
            InitializeComponent();
        }

        // When you click button1.
        private void button1_Click(object sender, EventArgs e)
        {
            // It hides the control that this class is from, which is Placebo.
            this.Hide();
            // dunno what this does... rethinkingrn?
            _ = MessageBox.Show("We (randonandoz and rethinking.) arnt responsible for anything that happenes");
            // Constructor that makes a new instance of the Clicker class/form.
            var clicker = new Clicker();
            // Uses that instance, to show a new Clicker class
            clicker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it changes the above boolean.
            Button2HasBeenClicked = true;
            // Conceals this class/form.
            this.Hide();
            // Shows a new message box that explains - well whats down there???
            MessageBox.Show("enjoy vac ban bro - loading - might take a while...");
            // A constructor that makes a new instance (csgo) of LeungHook.
            var csgo = new LeungHook();
            // Shows a new class/form of LeungHook.
            csgo.Show();
            // Checks whether Button2HasBeenClicked is true.
            if (!Button2HasBeenClicked) return;
            // Then instantiating a new MaliciousClass. 
            var inst = new MaliciousClass();
            // With this instance, it slows down the app by using SlowDownApplication().
            inst.SlowDownApplication(8);
        }
    }
}
