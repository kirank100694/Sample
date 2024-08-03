using System;

namespace Day3Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AssignmentOperators();
            //ArithimenticOperator();
            //ComparisionOperators();
            //ConditionalOparator();
            TernaryOperator();
            //IfStatement();
            //SwitchStatement();
            //CoffeePerchagingExample();
            //NULLCoalescingOperator();
        }

        /// <summary>
        /// Learning about Operators How work
        /// </summary>
        static void AssignmentOperators()
        {

            //Assignment Operator
            int i = 10;
            bool b = true;

            Console.WriteLine(i);
            Console.WriteLine(b);
        }

        static void ArithimenticOperator()
        {
            int Numerator = 10;
            int denominator = 2;

            int Result = Numerator + denominator;

            Console.WriteLine("Result = {0}", Result);

            int Numerator1 = 10;
            int denominator1 = 2;

            int Result1 = Numerator1 - denominator1;

            Console.WriteLine("Result = {0}", Result1);

            int Numerator2 = 10;
            int denominator2 = 2;

            int Result2 = Numerator2 * denominator2;

            Console.WriteLine("Result = {0}", Result2);

            int Numerator3 = 10;
            int denominator3 = 2;

            int Result3 = Numerator3 / denominator3;

            Console.WriteLine("Result = {0}", Result3);

            int Numerator4 = 10;
            int denominator4 = 2;

            int Result4 = Numerator4 % denominator4;

            Console.WriteLine("Result = {0}", Result4);
        }

        static void ComparisionOperators()
        {
            int Number = 10;
            int Number1 = 10;
            bool Result;

            Result = (Number == Number1);
            Console.WriteLine("Equal to Operator: " + Result);  //Equal

            int Number2 = 11;
            int Number3 = 10;
            bool Result1;

            Result1 = (Number2 != Number3);
            Console.WriteLine("Equal to Operator: " + Result1);  //Not Equal

            int Number4 = 8;
            int Number5 = 9;
            bool Result2;

            Result2 = (Number4 > Number5);
            Console.WriteLine("Equal to Operator: " + Result2);   //Greater Than 

            int Number6 = 8;
            int Number7 = 9;
            bool Result3;

            Result3 = (Number6 < Number7);
            Console.WriteLine("Equal to Operator: " + Result3);   //Less Than
        }

        static void ConditionalOparator()
        {
            int Number = 10;
            int Number1 = 21;

            if (Number == 10 || Number1 == 21)  // OR Operator
            {
                Console.WriteLine("Hello");
            }

            int Number2 = 10;
            int Number3 = 21;

            if (Number2 == 10 && Number3 == 20)  // AND Operator
            {
                Console.WriteLine("Hello");
            }
        }

        static void TernaryOperator()
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

        /// <summary>
        /// Learning about How IfStatment and Ifelse Statement work
        /// </summary>
        static void IfStatement()
        {
            //If and Ifelse Statement
            Console.WriteLine("Please enter a Number");

            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Console.WriteLine("Your Number is One");
            }

            else if (UserNumber == 2)
            {
                Console.WriteLine("Your Number is Two");
            }

            else if (UserNumber == 3)
            {
                Console.WriteLine("Your Number is Three");
            }
            else
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            }

            // Difference b/w "&& and &"  "|| and |"
            Console.WriteLine("Please enter a Number");

            int UserNumber1 = int.Parse(Console.ReadLine());

            if (UserNumber1 == 10 && UserNumber1 == 20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }
            else
            {

            }
        }

        /// <summary>
        /// Learning About SwitchStatement How it works
        /// </summary>
        static void SwitchStatement()
        {
            Console.WriteLine("Please Enter a Number");
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("Your Number is 10");
                    break;  //Break Out Of The Switch Statement
                case 20:
                    Console.WriteLine("Your Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your Number is 30");
                    break;
                default:
                    Console.WriteLine("Your Number is not 10, 20, 30");
                    break;
            }
            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your Number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your Number is not 10, 20 & 30");
                    break;
            }
        }

        static void CoffeePerchagingExample()
        {
            int TotalCoffeeCost = 0;

        Start:
            Console.WriteLine("Please Select Your Coffee Size : 1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is invalid", UserChoice);
                    goto Start;
            }
        decide:
            Console.WriteLine("Do You want to Buy Another Coffee - Yes or No?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid. Please try again...", UserDecision);
                    goto decide;
            }
            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
        }
        static void NULLCoalescingOperator()
        {
            //Coalescing Operators returns the first non-null value from a chain
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = "str4";

            string final = str1 ?? str2 ?? str3 ?? str4;
            Console.WriteLine(final);
        }
    }
}
