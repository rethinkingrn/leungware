﻿using System;
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
    // ReSharper disable once IdentifierTypo
    public partial class LeungHook : Form
    {
        // ReSharper disable once IdentifierTypo
        public LeungHook()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar2.Value.ToString();
        }

        private void PlaceboGo(object sender, EventArgs e)
        {
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            var inst = new MaliciousClass();
            inst.CrashProgram();
        }
    }
}
