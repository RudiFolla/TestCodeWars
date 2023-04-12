using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataBetweenExtremes
    {
        public static int BetweenExtremes(int[] numbers)
        {
            int result;
            //solution with linq
            //result = numbers.Max() - numbers.Min();

            int maxValue = numbers[0];
            int minValue = numbers[0];
            //solution with for
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                    maxValue = numbers[i];
                if (numbers[i] < minValue)
                    minValue = numbers[i];
            }
            result = maxValue - minValue;
            return result;
        }
    }
}
