using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataMask
    {
        public static string Maskify(string cc)
        {
            if (cc.Length > 4)
            {
                string result = "";
                var tmp = cc.Substring(0, cc.Length - 4);
                var tmp2 = cc.Substring(cc.Length - 4);
                foreach (char c in tmp)
                    result += "#";
                return result+tmp2;
            }
            else
                return cc;
        }
    }
}
