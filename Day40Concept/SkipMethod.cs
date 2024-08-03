using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.PartitioningOperatorsSkipMethod
{
    /// <summary>
    /// Skip method is used to skip first 'n' number of records from datasource 
    /// and select remaining elements as an output where 'n' an integer which is passed in skip method
    /// It can be used in method syntax and mixed syntax.
    /// Skip method will not make any change in element position.
    /// </summary>
    public class SkipMethod
    {
        public void SkipMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            List<string> names = new List<string>() { "kim", "John", "Mark", "Ada", "Nitish" };

            var methodSyntax = numbers.Where(number => number > 4).Skip(3).ToArray();

            var mixedSyntax = (from name in names select name).Skip(2).ToList();

            Console.ReadLine();
        }

        public void SkipMethodSimpleExample()
        {
            char[] letters = {'c', 'y', 'p', 'q', 'l', 'a' };


            int[] digits = {202, 2002, 20002, 200002, 2000002 };

            Console.WriteLine("Original letters is: ");

            foreach (var letter in letters)
            {
                Console.Write(letter);
            }

            var methodSyntax = letters.Skip(4);
            Console.WriteLine("New letters: ");

            foreach (var value in methodSyntax)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Original digits is: ");

            foreach (var digit in digits)
            {
                Console.WriteLine(digit);
            }

            var methodSyntax1 = digits.Skip(2);

            Console.WriteLine("New letters: ");

            foreach (var letter in methodSyntax1)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();
        }
    }
}
