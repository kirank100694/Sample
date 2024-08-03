using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class DoWhileLoop
    {
        #region DoWhileLoopExample
        /// <summary>
        /// 1.Do while loop checks its condition at the end of the loop
        /// 2.This means that the loop is guarenteed to execute at least one time
        /// 3.Do loops are used tp present a menu to the user
        /// </summary>
        public void DoWhileLoopExample()
        {
            string userChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter your target?");
                int userTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");

                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, Please say Yes or No");
                    }
                }

                while (userChoice != "YES" && userChoice != "NO");
            }

            while (userChoice == "YES");
        }
        #endregion

        public void DoWhileLoopExample1()
        {
            int count = 0;

            do
            {
                Console.WriteLine($"Counting : {count}");
                count++;
            }
            while (count < 5); // Condition

            Console.WriteLine("Last count.");
        }

        /// <summary>
        /// We will create a program that simulates a simple banking system where users can deposit, 
        /// withdraw, and check their balance. 
        /// The program will continue to interact with the user using a do-while loop until the user chooses to exit.
        /// </summary>
        public void BankingSystemExampleUsingDoWhileLoop()
        {
            int balance = 900000; // Initial balance
            int choice;
            bool continueTransaction = true;

            Console.WriteLine("Welcome to the Banking System!");

            do
            {
                // Display menu
                Console.WriteLine();
                Console.WriteLine("1. Check Balance, 2. Deposit, 3. Withdraw, 4. Exit");
                Console.Write("Enter your choice: ");

                // Get user choice
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your current balance is: {balance} INR");
                            break;
                        case 2:
                            Console.Write("Enter amount to deposit: ");
                            if (int.TryParse(Console.ReadLine(), out int depositAmount) && depositAmount > 0)
                            {
                                balance += depositAmount;
                                Console.WriteLine($"Deposit successful. Your new balance is: {balance} INR");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Deposit failed.");
                            }
                            break;
                        case 3:
                            Console.Write("Enter amount to withdraw: ");
                            if (int.TryParse(Console.ReadLine(), out int withdrawAmount) && withdrawAmount > 0)
                            {
                                if (withdrawAmount <= balance)
                                {
                                    balance -= withdrawAmount;
                                    Console.WriteLine($"Withdrawal successful. Your new balance is: {balance} INR");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds. Withdrawal failed.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Withdrawal failed.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Exiting the Banking System. Goodbye!");
                            continueTransaction = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            } 
            while (continueTransaction);

            Console.WriteLine("Thank you for using the Banking System.");
        }

        #region CoffeePerchagingExampleUsingDOWHILELoop
        public void CoffeePerchagingExampleUsingDOWHILELoop()
        {
            int totalCoffeeCost = 0;
            string userDecision = string.Empty;
            do
            {
                int userChoice = -1;
                do
                {
                    Console.WriteLine("Please Select Your Coffee Size : 1 - Small, 2 - Medium, 3 - Large, 4 - ExtraLarge");
                    userChoice = int.Parse(Console.ReadLine());

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
                        case 4:
                            totalCoffeeCost += 4;
                            break;
                        default:
                            Console.WriteLine("Your Choice {0} is invalid", userChoice);
                            break;
                    }
                }
                while (userChoice != 1 && userChoice != 2 && userChoice != 3 && userChoice != 4);
                do
                {
                    Console.WriteLine("Do You want to Buy Another Coffee - Yes or No?");
                    userDecision = Console.ReadLine().ToUpper();

                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("your choice {0} is invalid. Please try again...", userDecision);
                    }
                }
                while (userDecision != "YES" && userDecision != "NO");
            }
            while (userDecision.ToUpper() != "NO");

            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }
        #endregion
    }
}

    

