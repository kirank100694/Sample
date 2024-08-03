using System;

namespace Day2Concepts
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Implicit();
            Explicit();
            //Boxing();
            //Unboxing();
            //Parse();
            //Tryparse();
            //NullCoalescingOperator();
            //Arrays();
            //Comments();
        }

        static void Implicit()
        {
            //implicit converion ==> no data loss
            int i1 = 100;
            Console.WriteLine(i1);

            long l1 = i1;
            Console.WriteLine(l1);

            float f1 = i1;
            Console.WriteLine(f1);
        }

        static void Explicit()
        {
                float f2 = 123.45F;
                Console.WriteLine(f2);
                Console.WriteLine("After conversion");

                int i2 = (int)f2;   //Typecast Operator
                Console.WriteLine(i2);

                long l2 = (long)f2; //Typecast Operator   
                Console.WriteLine(l2);

                int i3 = Convert.ToInt32(i2); //Convertclass Operator
                Console.WriteLine(i3);

                long l3 = Convert.ToInt32(l2);  //Convertclass Operator
                Console.WriteLine(l3);

                long l4 = long.MaxValue;
                Console.WriteLine(l4);

                int i4 = (int)l4;
                Console.WriteLine(i4);

                int l5 = Convert.ToInt32(l4);
                Console.WriteLine(l5);
        }
        static void Boxing()
        {
            int i = 100;    //Value Type
            Console.WriteLine(i);

            object obj = i; //Referance Type
            Console.WriteLine(obj);
        }

        static void Unboxing()
        {
            object obj = 100; //Referance Type
            Console.WriteLine(obj);

            int i1 = (int)obj;    //Value Type
            Console.WriteLine(i1);
        }

        //static int number;
        static string strNumber = "123"; //Global Variable

        static void Parse()
        {
            string strNumber = "1234";

            int number = int.Parse(strNumber);
            Console.WriteLine(number);

            long number1 = long.Parse(strNumber);
            Console.WriteLine(number1);

            //Read the number and want some of those numbers
            Console.WriteLine("Enter First Number");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            string SecondNumber = Console.ReadLine();

            Console.WriteLine($"sum of FirstNumber {firstNumber} and" +
                       $"SecondNumber {SecondNumber} is {firstNumber + SecondNumber}"); //Concotenation

            Console.WriteLine("Enter First Number");
            int firstNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int SecondNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of FirstNumber {firstNumber} and" +
                       $"SecondNumber {SecondNumber} is {firstNumber + SecondNumber}");
        }

        static void Tryparse()
        {
            string strNumber = "1234";

            int number = int.Parse(strNumber);
            Console.WriteLine(number);

            long number1 = long.Parse(strNumber);
            Console.WriteLine(number1);

            Console.WriteLine("Enter First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter Second Number");
            int SecondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of FirstNumber {firstNumber} and" +
                        $"SecondNumber {SecondNumber} is {firstNumber + SecondNumber}");

            //0-Value And Null Value
            Console.WriteLine(number); //Value Type ==>0

            if (strNumber == null)
            {
                Console.WriteLine("Null Value");// Referance Type ==>Null
            }
            else
            {
                Console.WriteLine(strNumber);
            }
        }
        
        static void NullCoalescingOperator()
        {
            string strNumber = null;

            Nullable<int> number1 = null;

            int? number = null;
            long? number2 = null;
            bool? bool3 = null;

            bool? AreYouMajor = null;
            AreYouMajor = false;
            AreYouMajor = true;
        }

        /// <summary>
        /// How Arrays Will Work
        /// </summary>
        static void Arrays()
        {
            int employeeId1 = 25;
            int employeeId2 = 40;
            int employeeId3 = 65;
            int employeeId4 = 98;
            int employeeId5 = 100;

            //Integer Array Declaration
            int[] employeeIds = new int[5];

            //Intialization
            employeeIds[0] = 25;
            employeeIds[1] = 40;
            employeeIds[2] = 65;
            employeeIds[3] = 98;
            employeeIds[4] = 100;

            Console.WriteLine(employeeIds[0]);
            Console.WriteLine(employeeIds[1]);
            Console.WriteLine(employeeIds[4]);

            //String Arry Declaration
            string[] employeeNames = new string[4];

            //Intialization
            employeeNames[0] = "Rahul";
            employeeNames[1] = "Ravi";
            employeeNames[2] = "Venu";
            employeeNames[3] = "Kiran";

            Console.WriteLine(employeeNames[3]);

            //Intialization And Declaration
            int[] employeeIds1 = new int[5] { 25, 45, 65, 98, 100 };
            int[] employeeIds2 = new int[] { 25, 45, 65, 98, 100, 222, 333, 444, 555 };
            int[] employeeIds3 = { 25, 45, 65, 98, 100, 222, 333, 444, 555 };

            string[] employeeNames1 = new string[4] { "Rahul", "Ravi", "Venu", "Kiran" };
            string[] employeeNames2 = new string[] { "Rahul", "Ravi", "Venu", "Kiran" };
            string[] employeeNames3 = { "Rahul", "Ravi", "Venu", "Kiran", "kk", "RR" };
        }

        /// <summary>
        /// Different Type Of Comments
        /// </summary>
        static void Comments()
        {
            //Single Line Comment

            //Console.WriteLine("Test1");
            //Console.WriteLine("Test2");
            //Console.WriteLine("Test3");
            //Console.WriteLine("Test4");
            //Console.WriteLine("Test5");

            //Muliline Comment

            /*Console.WriteLine("Test1");
            Console.WriteLine("Test2");
            Console.WriteLine("Test3");
            Console.WriteLine("Test4");
            Console.WriteLine("Test5"); */

            //page Or XML Comment
         
         
        }
    }
}

