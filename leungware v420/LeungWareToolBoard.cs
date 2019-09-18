using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace leungware_v420
{
    public partial class LeungWareToolBoard : Form
    {
        public bool DoExcecuteWithAdminRights = false;
        public LeungWareToolBoard()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DoExcecuteWithAdminRights = true;
        }
        
    }
}