using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.ExceptionHandlingInCSharp
{
    public class ExceptionHandling
    {
        public void ExceptionHandlingExample()
        {
            int number1 = 0;
            int number2 = 0;
            Console.WriteLine("Enter num1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            number2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int output = number1 / number2;
                Console.WriteLine(output);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("An Exception has occurred : {0}", exception.Message);
            }
        }

        public void ExceptionHandlingExample1()
        {
            int[] value = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);
            }

            try
            {
                Console.WriteLine(value[4]);
            }
            catch (IndexOutOfRangeException exception)
            {

                Console.WriteLine("An Exception has occurred : {0}", exception.Message);
            }

            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            int age =  19;

            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
    }
}
