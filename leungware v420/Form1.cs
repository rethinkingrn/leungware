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
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("i dont know how to code");
            InitializeComponent();
        }

        private void HenryHomhoClick(object sender, EventArgs e)
        {
            MessageBox.Show("useless af why are you looking here");
            MessageBox.Show("or is it?");
            var LeungWareToolBoard = new LeungWareToolBoard();
            LeungWareToolBoard.Show();
        }
    }
}
