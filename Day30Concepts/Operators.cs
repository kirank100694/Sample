using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    #region OperatorsInCSharp
    /// <summary>
    /// Operators are used to perform operations on variables and values.
    /// Types:  Assignment Operators (=)
    ///         Arithmentic Operator (+, -, *, /, %)
    ///         Comparision Operators (==, !=, >, >=, <, <=)
    ///         Conditional Oparator (&&, ||)
    ///         Ternary Operator (?:)
    /// </summary>
    internal class Operators
    {
        #region AssignmentOperators
        /// <summary>
        /// Assignment operators are used to assign values to variables.
        /// </summary>
        public void AssignmentOperators()
        {
            int number = 10;
            bool Value = true;

            Console.WriteLine(number);
            Console.WriteLine(Value);
        }
        #endregion

        #region ArithimenticOperator
        /// <summary>
        /// Arithmetic operators are used to perform common mathematical operations
        /// </summary>
        public void ArithimenticOperator()
        {
            int Numerator = 10;
            int denominator = 2;

            int Result = Numerator + denominator;

            Console.WriteLine("Result = {0}", Result); //Addition

            int Numerator1 = 10;
            int denominator1 = 2;

            int Result1 = Numerator1 - denominator1;

            Console.WriteLine("Result = {0}", Result1);  //Subtraction

            int Numerator2 = 10;
            int denominator2 = 2;

            int Result2 = Numerator2 * denominator2;

            Console.WriteLine("Result = {0}", Result2);  //Multiplication

            int Numerator3 = 10;
            int denominator3 = 2;

            int Result3 = Numerator3 / denominator3;

            Console.WriteLine("Result = {0}", Result3);  //Division

            int Numerator4 = 10;
            int denominator4 = 2;

            int Result4 = Numerator4 % denominator4;

            Console.WriteLine("Result = {0}", Result4);  //Modulus
        }
        #endregion

        #region ComparisionOperators
        /// <summary>
        /// Comparison operators are used to compare two values or variables.
        /// </summary>
        public void ComparisionOperators()
        {
            int Number1 = 10;
            int Number2 = 10;
            bool Result1;

            Result1 = (Number1 == Number2);
            Console.WriteLine("Equal to Operator: " + Result1);  //Equal

            int Number3 = 11;
            int Number4 = 10;
            bool Result2;

            Result2 = (Number3 != Number4);
            Console.WriteLine("Equal to Operator: " + Result2);  //Not Equal

            int Number5 = 8;
            int Number6 = 9;
            bool Result3;

            Result3 = (Number5 > Number6);
            Console.WriteLine("Equal to Operator: " + Result3);   //Greater Than 

            int Number7 = 8;
            int Number8 = 9;
            bool Result4;

            Result4 = (Number7 < Number8);
            Console.WriteLine("Equal to Operator: " + Result4);   //Less Than
        }
        #endregion

        #region ConditionalOperator
        /// <summary>
        /// The Conditional operater || is an or, which means it only needs one condition to be met, 
        /// while && requires both conditions to be met.
        /// </summary>
        public void ConditionalOperator()
        {
            int Number1 = 10;
            int Number2 = 21;

            if (Number1 == 10 || Number2 == 21)  // OR Operator
            {
                Console.WriteLine("Hello");
            }

            if (Number1 == 10 && Number2 == 20)  // AND Operator
            {
                Console.WriteLine("Hello");
            }
        }
        #endregion

        #region TernaryOperator
        /// <summary>
        /// The Ternary operator “?:” 
        /// uses the Boolean value of an expression to determine 
        /// which two other expressions must be calculated and returned as a result.
        /// </summary>
        public void TernaryOperator()
        {
            int Number = 10;

            bool IsNumber;

            if (Number == 10)
            {
                IsNumber = true;
            }
            else
            {
                IsNumber = false;
            }
            Console.WriteLine("Number == 10 is {0}", IsNumber);

            int Number1 = 15;

            bool IsNumber1 = Number1 == 10 ? true : false;

            Console.WriteLine("Number == 15 is {0}", IsNumber1);
        }
        #endregion
    }
    #endregion
}
