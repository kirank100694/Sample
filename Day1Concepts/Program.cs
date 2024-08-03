using System;

namespace Day1Concepts
{
    internal class Program
    {
        static int userNumber = 1234;  //global variable
        static void Main(string[] args)
        {
            ReadingAndWritingToAConsole();
            //Variable();
            //BuiltInDataTypes();
        }

        static void ReadingAndWritingToAConsole()
        {
            int number = 12345;
            string name = "Savar Technologies";

            Console.WriteLine(number);
            Console.WriteLine(name);

            Console.WriteLine("Saver");
            Console.WriteLine("Technologies");

            Console.WriteLine("Please Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", firstName, lastName);
        }

        static void Variable()
        {
            int userNumber = 1234; // local variable
            Console.WriteLine(userNumber);

            string userName = "Saver";
            Console.WriteLine(userName);
        }

        static void BuiltInDataTypes()
        {
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            int maxValueOfInt = 2147483647;
            long maxValueOfLong = 9223372036854775807;

            // Float,  double, decimal
            Console.Write($"Size of float is {sizeof(float)}\n");   
            Console.WriteLine($"Max value Of float is{int.MaxValue}");
            Console.WriteLine($"Min value Of float is{int.MinValue}\n");

            Console.Write($"Size of double is {sizeof(double)}\n");
            Console.WriteLine($"Max value Of double is{double.MaxValue}");
            Console.WriteLine($"Min value Of double is{double.MinValue}\n");

            Console.Write($"Size of decimal is {sizeof(decimal)}\n");
            Console.WriteLine($"Max value Of decimal is{decimal.MaxValue}");
            Console.WriteLine($"Min value Of decimal is{decimal.MinValue}\n");

            float number1 = 23.45f;

            double number2 = 23.5;

            decimal number3 = 23.5m;

            //boolean, char

            bool invalid = true;
            char ch = 'a';

            //Referance data types  "string"

            string name = "Welcome to our Family";

            string password = "Family!@#123";
        }
    }
}
