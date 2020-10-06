using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms.VisualStyles;

namespace leungware_v420
{
    [SuppressMessage("ReSharper", "MemberCanBeMadeStatic.Global")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class ExecutorClass
    {
        // Executes an app of .exe extension
        public void LaunchFileOfExeExt(string applicationNameExe, bool executeWithAdminPriv)
        {
            // Makes a new process.
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            Process process = new Process();
            // try{}catch{}'es this
            try
            {
                // Adds a file to the process that was created from the passed in value of applicationNameExe
                process.StartInfo.FileName = applicationNameExe;
                // Checks whether the passed in boolean executeWithAdminPriv is true, if so, it runs with admin.
                if (executeWithAdminPriv)
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.Verb = "runas";
                    process.Start();
                }
                // If executeWithAdminPriv is not true, then it runs regularly.
                else
                {
                    process.StartInfo.FileName = applicationNameExe;
                    process.Start();
                }
            }
            // This catch is to prevent catastrophic failure of the app, causing a crash, instead, it handles it "gracefully"
            catch (Exception)
            {
                // Do nothing
            }
        }
    }
}