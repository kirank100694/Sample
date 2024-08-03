using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts
{
    public static class ArrayClassConcept
    {
        public static void ArrayClass()
        {
            string[] arrMonths = new string[]
            {
                "January",
                "February",
                "March",
                "April"
            };
            for (int i = 0; i < arrMonths.Length / 2; i++)
            {
                string tmp = arrMonths[i];
                arrMonths[i] = arrMonths[arrMonths.Length - i - 1];
                arrMonths[arrMonths.Length - i - 1] = tmp;
            }

            Array.Reverse(arrMonths);

            Array.Sort(arrMonths);
            Console.WriteLine("\nThe sorted order of given months: \n ");
            foreach (var month in arrMonths)
            {
                Console.WriteLine(month);
            }

            bool isMarchExist = Array.Exists(arrMonths, x => x == "March");
            Console.WriteLine($"\nIs March Exist:{isMarchExist}");
            Console.ReadKey();
        }
    }
}
