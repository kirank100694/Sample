using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    /// <summary>
    /// Method Parameters types =>
    /// 1. Value parameters : Creates a copy of the parameters passed, So modifications does not effect each other.
    /// 2. Reference Parameters : The keyword on a method parameter causes a method to refer to 
    ///    the same variable that was passes into the methods
    /// 3. Out Parameters: Use when you want a method to return more then one value
    /// 4. Parameter array: To pass into a method any number of arguments as a single logical 
    ///    parameter of a particular type, by using the params keyword.
    /// </summary>
    internal class MethodParameters
    {
        #region ValueParameters
        /// <summary>
        /// Passing by Value Parameters
        /// </summary>
        public void ValueParameters()
        {
            int i = 0;
            SimpleMethod(i);

            Console.WriteLine(i);
        }

        public static void SimpleMethod(int j)
        {
            j = 111;
        }
        #endregion

        #region ReferanceParameters
        /// <summary>
        /// Passing by Referance Parameters
        /// </summary>
        public void ReferanceParameters()
        {
            int i = 0;
            SimpleMethod(ref i);

            Console.WriteLine(i);
        }

        public static void SimpleMethod(ref int j)
        {
            j = 111;
        }
        #endregion

        #region OutputMethodParameters
        public void OutputMethodParameters()
        {
            int total = 0;
            int product = 0;

            Calculate(10, 20, out total, out product);

            Console.WriteLine("Sum = {0} && Product = {1}", total, product);
        }

        public static void Calculate(int firstNumber, int secondNumber, out int Sum, out int Product)
        {
            Sum = firstNumber + secondNumber;
            Product = firstNumber * secondNumber;
        }
        #endregion

        #region ParametersArrays
        public void ParametersArrays()
        {
            int[] numbers = new int[3];

            numbers[0] = 111;
            numbers[1] = 222;
            numbers[2] = 333;

            ParamsMethod();
            ParamsMethod(numbers);
            ParamsMethod(1, 2, 3, 4, 5);  // Argumnets For Parameters
        }

        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} Elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
    }
}
