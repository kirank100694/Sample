using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OptionalParametersArray
{
    /// <summary>
    /// C# allows you to pass into a method any number of arguments as a single logical parameter of a particular type, 
    /// by using the params keyword. You can combine a params argument with other optional parameters, 
    /// but it must be the last argument in the parameter list, and there can be only one in the function definition.
    /// </summary>
    public class ParameterArray
    {
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }
            Console.WriteLine("Sum =" + result);
        }
    }
}
