using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataArrayPacking
    {
        private static int bits = 8;
        public static int ArrayPacking(int[] a)
        {
            string bytesResult = "";
            foreach (int num in a)
            {
                //method to convert a number to a string in the base selected (in this case is 2)
                var toBits = Convert.ToString(num, 2);
                if (toBits.Length < bits)
                    toBits = toBits.PadLeft(bits, '0');
                bytesResult = bytesResult.Insert(0, toBits);
            }
            return Convert.ToInt32(bytesResult, 2);
        }
    }
}
