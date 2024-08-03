using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class TakeMethod
    {
        public static void ExampleOfTakeMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Take(5).Where(x => x > 3).ToArray();

            var mixedSyntax = (from n in numbers 
                               where n > 3
                               select n).Take(4).ToList();

            Console.ReadLine();
        }
    }
}
