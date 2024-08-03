using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts
{
    internal class BoxingUnboxingParseAndTryparse
    {
        #region BoxingTypeConversion
        /// <summary>
        /// Boxingtype conversion is a value type variable into refernce type variable implicit process
        /// </summary>
        public void BoxingTypeConversion()
        {
            int number = 100;    //Value Type
            Console.WriteLine(number);

            object value = number; //Referance Type
            Console.WriteLine(value);
        }
        #endregion

        public void BoxingTypeConversionExample() 
        {
            float number = 20.14159f;

            string value = number.ToString(); 
            Console.WriteLine(value);
        }

        #region UnboxingTypeConversion
        /// <summary>
        /// Unboxingtype conversion is a refernce type variable into value type variable Explicit process
        /// </summary>
        public void UnboxingTypeConversion()
        {
            object number = 100; //Referance Type
            Console.WriteLine(number);

            int value = (int)number;    //Value Type
            Console.WriteLine(value);
        }
        #endregion

        #region UnboxingTypeConversionExample
        public void UnboxingTypeConversionExample()
        {
            string stringValue = "3.14159";

            float floatValue = float.Parse(stringValue);
            Console.WriteLine(floatValue);
        }
        #endregion

        #region ParseTypeConversion
        /// <summary>
        /// Parse converts the string data type to another data type. 
        /// Before using Parse, we have to make sure the conversion will take place successfully. 
        /// Otherwise, the program will crash.
        /// </summary>
        static string strNumber = "123456"; //Global Variable
        public void ParseTypeConversion()//to do
        {
            string stringNumber = "1234";

            int number = int.Parse(stringNumber);
            Console.WriteLine(number);

            long number1 = long.Parse(stringNumber);
            Console.WriteLine(number1);

            //Read the number and want some of those numbers
            Console.WriteLine("Enter First Number");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            string secondNumber = Console.ReadLine();

            Console.WriteLine($"sum of FirstNumber {firstNumber} and" +
                       $"SecondNumber {secondNumber} is {firstNumber + secondNumber}"); //Concotenation
        }
        #endregion

        #region ParseTypeConversionExample
        /// <summary>
        /// The int.Parse() method converts the string, "4", into an integer value of 4.
        /// The float.Parse() method converts the variable of string, "4.5", into a float value of 4.5.
        /// </summary>
        public void ParseTypeConversionExample()
        {
            string varString = "4.5";
            
            Console.WriteLine(int.Parse("4") + 3);
            Console.WriteLine(float.Parse(varString) + 4.4f);
        }
        #endregion

        #region TryParseTypeConversion
        /// <summary>
        /// TryParse converts the string data type into another data type. 
        /// It returns 0 if the conversion fails. 
        /// TryParse is a safer approach because it does not terminate the execution of the program.
        /// </summary>
        public void TryParseTypeConversion()
        {
            string stringNumber = "1234";

            int intNumber = int.Parse(stringNumber);
            Console.WriteLine(intNumber);

            long longNumber = long.Parse(stringNumber);
            Console.WriteLine(longNumber);

            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter Second Number");
            int SecondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of FirstNumber {firstNumber} and " +
                        $"SecondNumber {SecondNumber} is {firstNumber + SecondNumber}");

            //0-Value And Null Value
            Console.WriteLine(intNumber); //Value Type ==>0

            if (strNumber == null)
            {
                Console.WriteLine("Null Value");// Referance Type ==>Null
            }
            else
            {
                Console.WriteLine(strNumber);
            }
        }
        #endregion

        #region TryParseTypeConversionExample
        public void TryParseTypeConversionExample()
        {
            string textExample = "5.5";
            Console.WriteLine(textExample);

            Console.WriteLine("Enter First Number");
            float.TryParse(Console.ReadLine(), out float firstNumber);

            Console.WriteLine("Enter Second Number");
            float SecondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine($"sum of FirstNumber {firstNumber} and " +
                        $"SecondNumber {SecondNumber} is {firstNumber + SecondNumber}");
        }
        #endregion
    }
}
