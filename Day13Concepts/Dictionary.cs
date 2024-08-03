using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.Dictionary
{
    public static class Dictionarys
    {
        public static void Months()
        {
            List<string> lstMonths = new List<string>();
            lstMonths.Add("January");
            lstMonths.Add("February");
            lstMonths.Add("March");
            lstMonths.Add("April");
            lstMonths.Add("May");
            lstMonths.Add("June");
            lstMonths.Add("July");
            lstMonths.Add("August");
            lstMonths.Add("September");
            lstMonths.Add("October");
            lstMonths.Add("November");
            lstMonths.Add("December");

            var march = lstMonths[2];
            var april = lstMonths[3];

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
            if (days.TryGetValue("sun",out string sun))
            {

            }
            foreach (var kvp in days)
            {
                Console.WriteLine($"key : {kvp.Key}, value: {kvp.Value}");
            }
            foreach(var key in days.Values)
            {

            }
           
            if (days.ContainsValue("sunday"))
            {

            }

            days.Clear();
            if(days.ContainsKey("sun"))
            {
                days.Remove("sunday");
            }

            Console.ReadKey();
        }
    }
}
