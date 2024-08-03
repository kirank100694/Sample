using System;
using Day9Concepts.OptionalParameters;
using Day9Concepts.OptionalParameter;
using Day9Concepts.OptionalParameter;
using Day9Concepts.OptionalParameter;
using Day9Concepts.CodeSnippets;
using StringMethod = Day9Concepts.OverrideToStringMethod;
using ConvertToString = Day9Concepts.ConvertToStringAndTostring;
using Day9Concepts.StringAndStringBuilder;
using Day9Concepts.TypesAndTypeMumbers;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Text;

namespace Day9Concepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ParameterArrays();
            //MethodOverload();
            //PerameterDefault();
            //OptionalAttribute();
            //CodeSnippet();
            //StringMethods();
            //ConvertToStrings();
            //StringBuilders();
            String();
            //TypesAndTypeMumber();
        }

        public static void ParameterArrays()
        {
            ParameterArray.AddNumbers(10, 20, 30, 40, 50);
            ParameterArray.AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }

        public static void MethodOverload()
        {
            MethodOverloading.AddNumbers(10, 20, null);
            MethodOverloading.AddNumbers(10, 20, 30, 40);
        }

        public static void PerameterDefault()
        {
            PerameterDefaults.AddNumbers(10, 20);
            PerameterDefaults.Test(1, c: 2);
        }

        public static void OptionalAttribute()
        {
            OptionalAttributes.AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        /// <summary>
        /// Examples of CodeSnippet And Surround-with code Snippets
        /// </summary>
        public static void CodeSnippet()
        {
            
        }

        public static void StringMethods()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            StringMethod.Customer C1 = new StringMethod.Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Console.WriteLine(Convert.ToString(C1));
        }

        public static void ConvertToStrings()
        {
            ConvertToString.Customer C1 = null;
            //string str = Convert.ToString(C1);
            string str = C1.ToString();
            Console.WriteLine(str);
        }

        public static void StringBuilders()
        {
            string userString = "C# ";
            userString += "Videos ";
            userString += "Tutorial ";
            userString += "for ";
            userString += "Beginners ";
            Console.WriteLine(userString);

            StringBuilder userstring = new StringBuilder();
            userstring.Append("C# ");
            userstring.Append("Videos ");
            userstring.Append("Tutorial ");
            userstring.Append("for ");
            userstring.Append("Beginners ");
            Console.WriteLine(userString.ToString());
        }

        /// <summary>
        /// Another Example of StringBuilder
        /// </summary>
        public static void String()
        {
            string userString = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                userString += i.ToString() + " ";
            }
            Console.WriteLine(userString);
        }

        public static void TypesAndTypeMumber()
        {

        }
    }
}
