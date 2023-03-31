using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataStatisticsAA
    {
        public static string Stat(string strg)
        {
            //Need to remember to use the right time format for string conversion


            if (strg == "")
                return "";
            string result = "";
            string median = "";
            List<TimeOnly> times = new List<TimeOnly>();

            var timesStr = strg.Split(",");
            
            foreach (var time in timesStr)
            {
                times.Add(TimeOnly.Parse(time.Replace("|", ":")));
            }
            times = times.OrderBy(x=>x).ToList();
            
            var range = (times.Max()-times.Min()).ToString().Replace(":", "|");

            var averageSum = times.Select(x => x.ToTimeSpan().TotalSeconds).Sum();
            var average = TimeSpan.FromSeconds(Math.Floor(averageSum / times.Count)).ToString().Replace(":","|");
            
            if (times.Count % 2 == 0)
            {
                var startIndex = times.Count / 2;
                var medianSum = TimeSpan.Parse(times[startIndex - 1].ToString("HH:mm:ss"))+TimeSpan.Parse(times[startIndex].ToString("HH:mm:ss"));
                median = TimeSpan.FromSeconds(Math.Floor((medianSum.TotalSeconds / 2))).ToString().Replace(":","|");
             }
            else
                median = times[times.Count / 2].ToString("HH|mm|ss");

            result = "Range: "+range+" Average: "+average +" Median: "+median;
            return result;
        }
    }
}
