using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class LastVSLastOrDefaultMethod
    {
        public static void SimpleExampleOfLastVSLastOrDefaultMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(x => x > 9).Last();

            var methodSyntax1 = numbers.Where(x => x > 15).LastOrDefault();

            var mixedSyntax = (from n in numbers
                               where n > 9
                               select n).Last();

            var mixedSyntax1 = (from n in numbers
                               where n > 15
                               select n).LastOrDefault();

            Console.ReadLine();
        }
    }
}
