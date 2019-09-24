using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace leungware_v420
{
    public class ExecutorClass
    {
        public void LaunchFileOfExeExt(string applicationNameExe, bool executeWithAdminPriv)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = applicationNameExe;
                if (executeWithAdminPriv)
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.Verb = "runas";
                    process.Start();
                }

                else
                {
                    process.StartInfo.FileName = applicationNameExe;
                    process.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}