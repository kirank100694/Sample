using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListOfSimpleType
{
    /// <summary>
    /// Sorting a list of simple types like int, string, char etc is straight forward.
    /// Just invoke the Sort() method on the list instance and the data will be automatically sorted in ascending  order.
    /// .Net can not sort complex type.
    /// </summary>
    public class SimpleType
    {
        public void SimpleTypeExample()
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers after sorting");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();

            Console.WriteLine("Numbers in Decending order");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alphabets before sorting");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();

            Console.WriteLine("Alphabets in Decending order");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}
