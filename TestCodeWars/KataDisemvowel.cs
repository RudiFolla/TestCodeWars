using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataDisemvowel
    {
        public static string Disemvowel(string str)
        {
            string pattern = "[a|A|e|E|i|I|o|O|u|U]{1,1}";
            Regex regex = new(pattern);
            MatchCollection matchCollection = regex.Matches(str);
            List<string> done = new();
            foreach (Match match in matchCollection)
            {
                if (done.Contains(match.Value))
                    continue;
                else
                {
                    str = str.Replace(match.Value, "");
                    done.Add(match.Value);
                }
            }
            return str;
        }
    }
}
