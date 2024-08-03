using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperatorsElementAtVSElementAtORDefault
{
    /// <summary>
    /// ElementAtVSElementAtORDefault method both are used (Independently) to return elementat from a datasource.
    /// If the element is not available at last index,
    ///     1.ElementAt will throw an exception
    ///     2.But ElementAtORDefault will return default value of datasource element.
    /// </summary>
    public class ElementAtVSElementAtORDefaultMethod
    {
        public void ElementAtVSElementAtORDefaultExample()
        {
            string[] animals = {"Dog", "Cat", "Cow", "Goat", "Parrot" };

            var methodSyntax = animals.ElementAt(3);

            foreach (var animal in methodSyntax)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();
        }

        public void ElementAtVSElementAtORDefaultSimpleExample()
        {
            var numbers = new int[] { 1, 2, 3 };

            var methodSyntax = numbers.ElementAtOrDefault(2);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
