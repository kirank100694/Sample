using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts
{
    public static class ExceptionType
    {
        public static void DisplayType()
        {
            try
            {
                Console.WriteLine(Arthimetic(-1, 0));
                
            }
            catch(NumDenoEqualException ex)
            {
                Console.WriteLine(1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero not possible corrected to 1,{0}",ex.Message);
                Console.WriteLine(Arthimetic(-1, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        private static int Arthimetic(int num1, int num2)
        {
            try
            {
                int Value = Divide(num1, num2);
                return Value;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private static int Divide(int num1, int num2)
        {
            if ((num1 <0) || (num2 < 0))
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
    }
}
