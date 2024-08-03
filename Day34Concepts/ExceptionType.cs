using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.ExceptionType
{
    /// <summary>
    /// An exception is defined as an event that occurs during the execution of a program that is unexpected by the program code.
    /// Try: Used to define a try block. This block holds the code that may throw an exception.
    /// Catch : Used to define a catch block. This block catches the exception thrown by the try block.
    /// Finally: Used to define the finally block. This block holds the default code.
    /// Throw : Used to throw an exception manually.
    /// </summary>
    public static class ExceptionTypes
    {
        public static void DisplayExceptionType()
        {
            try
            {
                Console.WriteLine(Arthimetic(-1, 0));

            }
            catch (NumDenoEqualException exception)
            {
                Console.WriteLine("An Exception has occurred : {0}", exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Divide by zero not possible corrected to 1,{0}", exception.Message);
                Console.WriteLine(Arthimetic(-1, 1));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        private static int Arthimetic(int number1, int number2)
        {
            try
            {
                int Value = Divide(number1, number2);
                return Value;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private static int Divide(int num1, int num2)
        {
            if ((num1 < 0) || (num2 < 0))
            {
                throw new Exception("Negative numbers not allowed");
            }
            if (num1 == num2)
            {
                throw new NumDenoEqualException("Numerator and denomenator are same");
            }
            int num3 = (num1 / num2);
            return num3;
        }
        public class NumDenoEqualException : Exception
        {
            public NumDenoEqualException(String message) : base(message)
            {

            }
        }

        /// <summary>
        /// Try to generate an exception, Catch block for invalid array access, Catch block for attempt to divide by zero
        /// Catch block for value being out of range, Will execute irrespective of the above catch blocks
        /// </summary>
        public static void ExceptionTypeExample()
        {
            int[] value = { 19, 0, 75, 52 };

            try
            {
                for (int i = 0; i < value.Length; i++)
                {
                    Console.WriteLine(value[5]);
                    Console.WriteLine(value[i] / value[i + 1]);
                }
            }

            catch (IndexOutOfRangeException exception)
            {

                Console.WriteLine("An Exception has occurred : {0}", exception.Message);
            }

            catch (DivideByZeroException exception)
            {

                Console.WriteLine("An Exception has occurred : {0}", exception.Message);
            }

            catch (ArgumentOutOfRangeException exception)
            {

                Console.WriteLine("An Exception has occurred : {0}", exception.Message);
            }

            finally
            {
                for (int i = 0; i < value.Length; i++)
                {
                    Console.Write(" {0}", value[i]);
                }
            }
        }
    }
}
