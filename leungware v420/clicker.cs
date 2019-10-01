using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leungware_v420
{
    public partial class Clicker : Form
    {
        public Clicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            // I have no clue what im doing
            // vvvv if user clicked yes
                if (dialog == DialogResult.Yes)
            {
                this.Hide();
                var back = new Placebo();
                back.Show();

            }
            else if (DialogResult == DialogResult.No)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar2.Value.ToString();
        }
        // basically explaning what each of the buttons does
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The amount of Clicks that are happening in a second");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How much the clicks vary. Example: set the value to 2 the clicks will be within 2 cps of the selected value");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
