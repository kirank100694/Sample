using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.ComparingTwoArrays
{
    public static class ComparingArray
    {
        public static void ComparingArrays()
        {
            string[] daysOfWeek_arr1 =
            {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
            };

            string[] daysOfWeek_arr2 =
            {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
            };
            bool isEqual = daysOfWeek_arr1 == daysOfWeek_arr2;
            Console.WriteLine($"is dayofWeek_arr1 == dayOfWeek_arr2: {isEqual}");
            bool isArrayEqual = true;
            if (daysOfWeek_arr1.Length == daysOfWeek_arr2.Length)
            {
                for (int i = 0; i < daysOfWeek_arr2.Length; i++)
                {
                    if (daysOfWeek_arr1[i] != daysOfWeek_arr2[i])
                    {
                        isArrayEqual = false;
                    }
                }
            }
            else
            {
                isArrayEqual = false;
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine("\nComparing using For Forloop - Compares each item of the 2 arrays");
            if (isArrayEqual)
            {
                Console.WriteLine("\nBoth arrays are equal");
            }
            else
            {
                Console.WriteLine("\nBoth arrays are not equal");
            }

            Console.WriteLine("\nUsing Extension method SequenceEqual:");
            bool issSequenceEqual = daysOfWeek_arr1.SequenceEqual(daysOfWeek_arr2);
            Console.WriteLine($"\nSequenceEual = {isArrayEqual}");

            Console.ReadKey();
        }    
    }
}
