using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.DictionarysInCSharp
{
    /// <summary>
    /// Dictionary is a generic collection which is generally used to store key/value pairs. 
    /// The working of Dictionary is quite similar to the non-generic hashtable. 
    /// The advantage of Dictionary is, it is generic type. Dictionary is defined under System.Collections.Generic
    /// </summary>
    public class Dictionarys
    {
        public void Months()
        {
            List<string> lastMonths = new List<string>();
            lastMonths.Add("January");
            lastMonths.Add("February");
            lastMonths.Add("March");
            lastMonths.Add("April");
            lastMonths.Add("May");
            lastMonths.Add("June");
            lastMonths.Add("July");
            lastMonths.Add("August");
            lastMonths.Add("September");
            lastMonths.Add("October");
            lastMonths.Add("November");
            lastMonths.Add("December");

            var march = lastMonths[2];
            var april = lastMonths[3];

            var months = new Dictionary<int, string>
            {
                {1, "January" },
                {2, "February" },
                {3, "March" },
                {4, "April" },
                {5, "May" },
                {6, "june" }
            };
            months[7] = "July";
            months[8] = "August";

            months.Add(10, "October");
            months.Add(11, "November");
            months[11] = "December";

            var days = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            days["sun"] = "sunday";
            days["mon"] = "monday";

            //days.Add("Sun", "Tuesday");

            var sunday = days["sun"];
            if (days.TryGetValue("sun", out string sun))
            {
                days.Add("sunday", sun);
            }
            foreach (var keyvaluepair in days)
            {
                Console.WriteLine($"key : {keyvaluepair.Key}, value: {keyvaluepair.Value}");
            }
            foreach (var key in days.Values)
            {
                Console.WriteLine(key);
            }

            if (days.ContainsValue("sunday"))
            {
                Console.WriteLine("monday");
            }

            days.Clear();
            if (days.ContainsKey("sun"))
            {
                days.Remove("sunday");
            }

            Console.ReadKey();
        }
    }
}
