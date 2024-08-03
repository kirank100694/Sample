using Day40Concepts.StudentTestDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperatorsTakeWhileMethod
{
    /// <summary>
    /// Takewhile method is used to get all records from a datasource until a specified condition is true.
    /// Once the condition is failed Takewhile will not validate rest elements even if the condition is true for remaining elements.
    /// It can be used in method syntax and mixed syntax.
    /// Takewhile method will not make any change in element position.
    /// </summary>
    public class TakeWhileMethod
    {
        public void TakeWhileMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            var querySyntax = (from number in numbers select number).TakeWhile(number => number < 7).ToArray();

            List<string> names = new List<string>() { "kim", "John", "Mark", "Ada", "Nitish" };

            var mixedSyntax = (from number in names select number).TakeWhile((name, index) => name.Length > index).ToList();

            Console.ReadLine();
        }

        public void TakeWhileMethodSimpleExample()
        {
            int[] sequence = {45, 67, 89, 13, 56, 76, 100, 90 };

            var methodSyntax = sequence.OrderBy(number => number).TakeWhile(numbers => numbers < 70);

            Console.WriteLine("New Sequence: ");

            foreach (var result in methodSyntax)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
