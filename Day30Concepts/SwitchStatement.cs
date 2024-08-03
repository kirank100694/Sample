using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    /// <summary>
    /// The switch statement to select one of many code blocks to be executed.
    /// The switch expression is evaluated once.
    /// The value of the expression is compared with the values of each case.
    /// If there is a match, the associated block of code is executed.
    /// The break and default keywords will be described later in this chapter.
    /// </summary>
    internal class SwitchStatement
    {
        #region SwitchStatementExample1
        public void SwitchStatementExample1()
        {
            Console.WriteLine("Please Enter Number");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
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
                    Console.WriteLine("Your Number is not 10, 20 & 30");
                    break;
            }
        }
        #endregion

        #region SwitchStatementExample2
        public void SwitchStatementExample2()
        {
            Console.WriteLine("Please Enter Number");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your Number is {0}", number);
                    break;
                default:
                    Console.WriteLine("Your Number is not 10, 20 & 30");
                    break;
            }
        }
        #endregion

        #region CoffeePerchagingExample
        /// <summary>
        /// I am trying to make a simple Coffee Perchaging Example using C#.
        /// Break : If break statement is used inside statement, the control will leave the switch statement.
        /// goto : We can either jump to another case statement, or to a specific label.
        ///        Using go to is bad programming style. We should avoid go to by all means.
        /// </summary>
        public void CoffeePerchagingExample()
        {

            int totalCoffeeCost = 0;

        Start:
            Console.WriteLine("Please Select Your Coffee Size : 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is invalid", userChoice);
                    goto Start;
            }
        decide:
            Console.WriteLine("Do You want to Buy Another Coffee - Yes or No?");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid. Please try again...", userDecision);
                    goto decide;
            }
            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }
        #endregion
    }
}

