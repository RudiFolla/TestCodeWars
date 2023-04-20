using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataIPV4ToInt32
    {
        private static int bits = 8;
        public static uint ToInt32(string ip)
        {
            string[] parts = ip.Split('.');
            string binary = "";
            foreach (var item in parts)
            {
                var toBits= Convert.ToString(Int32.Parse(item), 2);
                if (toBits.Length < bits)
                    toBits = toBits.PadLeft(bits, '0');
                binary += toBits;
            }
            return Convert.ToUInt32(binary, 2);
        }
    }
}
