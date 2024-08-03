using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class SkipMethod
    {
        public static void ExampleOfSkipMethod()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };
            List<string> names = new List<string>() { "kim", "John", "Mark", "Ada", "Nitish" };

            var methodSyntax = numbers.Where(x => x > 4).Skip(3).ToArray();

            var mixedSyntax = (from n in names select n).Skip(2).ToList();

            Console.ReadLine();
        }
    }
}
