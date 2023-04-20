using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataSpeedAndTime
    {
        public static int SpeedAndTime(int s, int t)
        {
            // forfeited couldn't think of how to get a solution
            char[] baseCase = new char[t];
            for (int i = 0; i < baseCase.Length; i++)
            {
                baseCase[i] = 'R'; 
            }
            var a = Math.Min(s / 3 + 1, (t + 1) / 2);
            return 0;
        }
    }
}
