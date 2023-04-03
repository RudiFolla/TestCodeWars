using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataPhoneDuplicate
    {
        public static string[] FindDuplicatePhoneNumbers(string[] PhoneNumbers)
        {

            //Base num form = 111-1111, the numbers can be changed with a character
            //in this way:
            //A, B, and C map to 2
            //D, E, and F map to 3
            //G, H, and I map to 4
            //J, K, and L map to 5
            //M, N, and O map to 6
            //P, R, and S map to 7
            //T, U, and V map to 8
            //W, X, and Y map to 9
            //letters can be uppercase or lowercase

            string pattern = "[0-9]{3}-[0-9]{4}";
            Regex regex = new(pattern);

            Dictionary<string, int> pairs = new();

            foreach (var phNum in PhoneNumbers)
            {
                if (regex.IsMatch(phNum))
                {
                    if (pairs.ContainsKey(phNum)) pairs[phNum]++; else pairs.Add(phNum, 1);
                }
                else
                {
                    var tmp = phNum.Replace("-", "");
                    tmp = FromCharacterToDigit(tmp);
                    if (pairs.ContainsKey(tmp)) pairs[tmp]++; else pairs.Add(tmp, 1);
                }

            }
            List<string> results = new();
            pairs = pairs.OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value); 
            foreach (var phNum in pairs)
            {
                if (phNum.Value == 1)
                    continue;
                results.Add(phNum.Key + ":" + phNum.Value);
            }

            return results.ToArray();
        }
        private static string FromCharacterToDigit(string str)
        {
            string pattern = "[A-Za-z]{1,1}";
            Regex regex = new(pattern);
            MatchCollection matchCollection = regex.Matches(str);
            List<string> done = new();
            if (matchCollection.Count == 0)
            {
                str = str.Insert(3, "-");
                return str;
            }
            foreach (Match match in matchCollection)
            {
                if (done.Contains(match.Value))
                    continue;
                else
                {
                    //needs to be changed
                    switch (match.Value.ToLower())
                    {
                        case "a":
                        case "b":
                        case "c":
                            str = str.Replace(match.Value.ToUpper(), "2").Replace(match.Value.ToLower(), "2");
                            break;
                        case "d":
                        case "e":
                        case "f":
                            str = str.Replace(match.Value.ToUpper(), "3").Replace(match.Value.ToLower(), "3");
                            break;
                        case "g":
                        case "h":
                        case "i":
                            str = str.Replace(match.Value.ToUpper(), "4").Replace(match.Value.ToLower(), "4");
                            break;
                        case "j":
                        case "k":
                        case "l":
                            str = str.Replace(match.Value.ToUpper(), "5").Replace(match.Value.ToLower(), "5");
                            break;
                        case "m":
                        case "n":
                        case "o":
                            str = str.Replace(match.Value.ToUpper(), "6").Replace(match.Value.ToLower(), "6");
                            break;
                        case "p":
                        case "r":
                        case "s":
                            str = str.Replace(match.Value.ToUpper(), "7").Replace(match.Value.ToLower(), "7");
                            break;
                        case "t":
                        case "u":
                        case "v":
                            str = str.Replace(match.Value.ToUpper(), "8").Replace(match.Value.ToLower(), "8");
                            break;
                        case "w":
                        case "x":
                        case "y":
                            str = str.Replace(match.Value.ToUpper(), "9").Replace(match.Value.ToLower(), "9");
                            break;
                        default:
                            break;
                    }

                    done.Add(match.Value.ToLower());
                    done.Add(match.Value.ToUpper());
                }
            }
            str = str.Insert(3, "-");
            return str;
        }
    }
}
