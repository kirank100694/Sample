using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperatorsSkipWhileMethod
{
    /// <summary>
    /// Skipwhile method is used to skip all records from a datasource until a condition is true and select remaining elements as an output.
    /// It can be used in method syntax and mixed syntax.
    /// Skipwhile method will not make any change in element position.
    /// </summary>
    public class SkipWhileMethod
    {
        public void SkipWhileMethodExample()
        {
            int[] numbers = new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10, 2 };

            var methodSyntax = numbers.SkipWhile(number => number < 6).ToArray();

            var mixedSyntax = (from number in numbers select number).SkipWhile(number => number < 5).ToArray();

            List<string> names = new List<string>() { "kim", "John", "Ma", "Adam", "Nitish" };

            var methodSyntax1 = names.SkipWhile((value, index) => value.Length > index).ToList();

            Console.ReadLine();
        }

        public void SkipWhileMethodSimpleExample()
        {
            int[] numbers = {45, 67, 89, 13, 56, 76, 67 };

            var methodSyntax = numbers.OrderBy(number => number).SkipWhile(number => number < 67);

            Console.WriteLine("Sequence: ");

            foreach (var values in methodSyntax)
            {
                Console.WriteLine(values);
            }
        }
    }
}
