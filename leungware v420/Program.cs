using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leungware_v420
{
    // ReSharper disable once ArrangeTypeModifiers
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            Application.Run(new Form1());
        }
    }
}
