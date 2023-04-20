using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataBinaryToString
    {
        public static string BinaryToString(string binary)
        {
            var text = new StringBuilder();
            for (int i = 0; i < binary.Length; i+=8)
            {
                var tmp = Convert.ToInt32(binary.Substring(i, 8), 2);
                text.Append(Convert.ToChar(tmp));
            }
            return text.ToString();
        }
    }
}
