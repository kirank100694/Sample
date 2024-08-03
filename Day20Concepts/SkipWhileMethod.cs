using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class SkipWhileMethod
    {
        public static void ExampleOfSkipWhileMethod()
        {
            int[] numbers = new int[] { 1, 3, 4, 5, 6, 7,  8, 9, 10, 2};

            List<string> names = new List<string>() { "kim", "John", "Ma", "Adam", "Nitish" };

            var methodSyntax = numbers.SkipWhile(num => num < 6).ToArray();

            var mixedSyntax = (from num in numbers select num).SkipWhile(x => x < 5).ToArray();

            var methodSyntax1 = names.SkipWhile((value, index) => value.Length > index).ToList();

            Console.ReadLine();
        }
    }
}
