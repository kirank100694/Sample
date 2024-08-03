using System;

namespace Day4Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DoWhileLoop();
            //CoffeePerchagingExampleUsingDOWHILELoop();
            //ForAndForeachLoop();
            //Method();
            //Methods();
            //ValueParameters();
            //ReferanceParameters();
            //OutputMethodParameters();
            ParametersArrays();
        }

        static void DoWhileLoop()
        {
            Console.WriteLine("Please enter your target?");
            int Usertarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= Usertarget)
            {
                Console.Write(Start + " ");
                Start = Start + 2;
            }

            string Userchoice1 = string.Empty;
            do
            {
                Console.WriteLine("Please enter your target?");
                int Usertarget1 = int.Parse(Console.ReadLine());

                int Start1 = 0;

                while (Start1 <= Usertarget1)
                {
                    Console.Write(Start1 + " ");
                    Start1 = Start1 + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");

                    Userchoice1 = Console.ReadLine().ToUpper();
                    if (Userchoice1 != "YES" && Userchoice1 != "NO")
                    {
                        Console.WriteLine("Invalid choice, Please say Yes or No");
                    }
                }
                while (Userchoice1 != "YES" && Userchoice1 != "NO");
            }
            while (Userchoice1 == "YES");
        }

        static void CoffeePerchagingExampleUsingDOWHILELoop()
        {
            int TotalCoffeeCost = 0;
            string UserDecision = string.Empty;
            do
            {
                int UserChoice = -1;
                do
                {
                    Console.WriteLine("Please Select Your Coffee Size : 1 - Small, 2 - Medium, 3 - Large, 4 - ExtraLarge");
                    UserChoice = int.Parse(Console.ReadLine());

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
                        case 4:
                            TotalCoffeeCost += 4;
                            break;
                        default:
                            Console.WriteLine("Your Choice {0} is invalid", UserChoice);
                            break;
                    }
                }
                while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3 && UserChoice != 4);
                do
                {
                    Console.WriteLine("Do You want to Buy Another Coffee - Yes or No?");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("your choice {0} is invalid. Please try again...", UserDecision);
                    }
                }
                while (UserDecision != "YES" && UserDecision != "NO");
            }
            while (UserDecision.ToUpper() != "NO");

            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
        }

        /// <summary>
        /// Knowing About For loop, Foreach loop, Break and Continue
        /// </summary>
        static void ForAndForeachLoop()
        {
            int[] Numbers = new int[4];

            Numbers[0] = 111;
            Numbers[1] = 222;
            Numbers[2] = 333;
            Numbers[3] = 444;

            //whileloop
            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }
            //ForLoop
            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }
            //ForeachLoop
            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }
            //Break And Continue
            for (int i1 = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break;
            }
            for (int i1 = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }
        }

        public static void Method()
        {
            //Static
            Program P = new Program();
            P.EvenNumber();
        }

        //Instance
        public void EvenNumber()
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        public static void Methods()
        {
            Program.EvenNumbers(40);

            Program p = new Program();
            int Sum = p.Add(10, 30);

            Console.WriteLine("Sum= {0}", Sum);
        }

        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public static void EvenNumbers(int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        /// <summary>
        /// Passing by Value Parameters
        /// </summary>
        static void ValueParameters()
        {
            int i = 0;
            SimpleMethod(i);

            Console.WriteLine(i);
        }

        public static void SimpleMethod(int j)
        {
            j = 111;
        }

        /// <summary>
        /// Passing by Referance Parameters
        /// </summary>
        static void ReferanceParameters()
        {
            int i = 0;
            SimpleMethod(ref i);

            Console.WriteLine(i);
        }

        public static void SimpleMethod(ref int j)
        {
            j = 111;
        }

        static void OutputMethodParameters()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);

            Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
        }

        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        static void ParametersArrays()
        {
            int[] Numbers = new int[3];

            Numbers[0] = 111;
            Numbers[1] = 222;
            Numbers[2] = 333;

            ParamsMethod();
            ParamsMethod(Numbers);
            ParamsMethod(1, 2, 3, 4, 5);  // Argumnets For Parameters
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} Elements", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
