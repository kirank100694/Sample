using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.MethodOverLoading
{
    /// <summary>
    /// Method overloading is allows you to define multiple methods with the same name but with different parameters. 
    /// </summary>
    public class MethodOverLoadingExample
    {
        /// <summary>
        /// Value Parameter
        /// </summary>
        public void Add(int one, int two, int three)
        {
            Console.WriteLine("Sum = {0}", one + two);
        }

        /// <summary>
        ///Output Parameter
        /// </summary>
        public void Add(int one, int two, out int Sum)
        {
            Console.WriteLine("Sum = {0}", one + two);
            Sum = one + two;
        }

        /// <summary>
        ///  Using Params Keyword
        ///  It is not posible To Overload Methods Based on the Peram keyword
        ///  </summary>
        public void Add(int one, int two, params int[] three)
        {
            Console.WriteLine("Sum = {0}", one + two);
        }

        public void Add1(int one, int two, int[] three)
        {
            Console.WriteLine("Sum = {0}", one + two);
        }
    }

    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        public long Add(long a, long b, long c)
        {
            return a + b + c;
        }
    }
}
