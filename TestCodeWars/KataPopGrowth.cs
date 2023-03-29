using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataPopGrowth
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            //p0 = starting population
            //percent = percentage growth (to divide by 100)
            //aug = costant people added by year
            //p = population to reach

            percent /= 100;
            int years = 0;
            while (p0<p)
            {
                p0 += (int)((double)p0 * percent) + aug;
                years++;
            }
            return years;
        }
    }
}
