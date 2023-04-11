using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataRgbToHex
    {
        public static string Rgb(int r, int g, int b)
        {
            string result = "";
            int[] rgbValues = { r, g, b };

            for (int i = 0; i < rgbValues.Length; i++)
            {
                if (rgbValues[i] < 0)
                    rgbValues[i] = 0;
                else if (rgbValues[i] > 255)
                    rgbValues[i] = 255;
                var tmp = Convert.ToString(rgbValues[i], 16);
                tmp = tmp.Length < 2 ? tmp.PadLeft(2, '0') : tmp;
                result += tmp;
            }
            return result.ToUpper();
        }
    }
}
