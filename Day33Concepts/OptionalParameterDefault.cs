using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OptionalParameterDefault
{
    public class PerameterDefaults
    {

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
        public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int numbers in restOfNumbers)
                {
                    result += numbers;
                }
            }
            Console.WriteLine("Total =" + result.ToString());
        }
    }
}
