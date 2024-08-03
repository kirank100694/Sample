using System;
using System.Collections.Generic;
using System.Linq;
using Day39Concepts.Helper;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.ExtensionMethodsExamples
{
    /// <summary>
    /// According MSDN, extension method enable you to "add" methods to existing types 
    /// without creating a new derived type, ercompiling, or otherwise modifying the original type.
    /// Extension methods are special kind of static method, but thet are called as if 
    /// they were instance methods on the extended type.
    /// LINQ's standard query operators(select,where etc) are implemented in 
    /// Enumerable class as extension methods on the IEnumerable<T> interface.
    /// </summary>
    public class ExtensionMethods
    {
        public void DisplayExtensionMethod()
        {
            string name = "saver";
            string result1 = name.ChangeFirstLetterCase();

            string result = StringHelper.ChangeFirstLetterCase(name);

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }

        public void DisplayEnumerable()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = Enumerable.Where(numbers, number => number % 2 == 0);

            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }
}
