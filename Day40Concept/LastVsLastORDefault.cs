using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperatorsLastVsLastORDefault
{
    /// <summary>
    /// LastVSLastOrDefault method both are used (Independently) to return last element from a datasource.
    /// If the element is not available at last index,
    ///     1.Last will throw an exception
    ///     2.But LastOrDefault will return default value of datasource element.
    /// </summary>
    public class LastVSLastOrDefaultMethod
    {
        public void LastVSLastOrDefaultMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(number => number > 9).Last();

            var mixedSyntax = (from number in numbers
                               where number > 9
                               select number).Last();

            Console.ReadLine();
        }

        public void LastVSLastOrDefaultMethodSimpleExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(number => number > 15).LastOrDefault();

            var methodSyntax1 = numbers.LastOrDefault(number =>number < 5);

            var querySyntax = (from number in numbers
                               select number).LastOrDefault();

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
