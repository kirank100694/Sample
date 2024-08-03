using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperatorsSingleVsSingleORDefault
{
    /// <summary>
    /// SingleVSSingleOrDefault method both are used (Independently) to return single element from a datasource.
    /// If the element is available at multiple places thenboth the methods will throw an exception.
    /// If no element is available in the datasource
    ///     1. Single will throw an exception
    ///     2. But SingleOrDefault will return default value of datasource elements.
    /// </summary>
    public class SingleVSSingleOrDefaultMethod
    {
        public void SingleVSSingleOrDefaultMethodExample()
        {
            List<int> numbers = new List<int>() { 1 };

            var methodSyntax = numbers.Where(number => number > 1).Single();

            Console.ReadLine();
        }

        public void SingleVSSingleOrDefaultMethodSimpleExample()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };

            var methodSyntax = numbers.SingleOrDefault(number => number > 10);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
