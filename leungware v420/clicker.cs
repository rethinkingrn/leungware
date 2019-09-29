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
    public partial class clicker : Form
    {
        public clicker()
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
                var back = new PLACEBO();
                back.Show();

            }
            else if (DialogResult == DialogResult.No)
            {

            }
        }
    }
}
