using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class TakeWhileMethod
    {
        public static void ExampleOfTakeWhileMethod()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            var methodSyntax = (from n in numbers select n ).TakeWhile(x => x < 7).ToArray();

            List<string> names = new List<string>() { "kim", "John", "Mark", "Ada", "Nitish"};

            var methodSyntax1 = (from n in names select n).TakeWhile((name, index) => name.Length > index).ToList();

            Console.ReadLine();
        }
    }
}
