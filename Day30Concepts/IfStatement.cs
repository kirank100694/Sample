using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class IfStatement
    {
        #region IfStatement
        /// <summary>
        /// An if statement is a programming construct that allows you to make decisions based on certain conditions.
        /// </summary>
        public void IfAndIfelseStatement()
        {
            //If and Ifelse Statement
            Console.WriteLine("Please Enter Number");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your Number is One");
            }

            else if (userNumber == 2)
            {
                Console.WriteLine("Your Number is Two");
            }

            else if (userNumber == 3)
            {
                Console.WriteLine("Your Number is Three");
            }
            else
            {
                Console.WriteLine("Your Number is not between 1 and 3");
            }

            // Difference b/w "&& and &"  "|| and |"
            Console.WriteLine("Please Enter Number");

            int userNumber1 = int.Parse(Console.ReadLine());

            if (userNumber1 == 10 && userNumber1 == 20)
            {
                Console.WriteLine("Your Number is 10 or 20");
            }

            Console.WriteLine("Please Enter Number");

            int userNumber2 = int.Parse(Console.ReadLine());

            if (userNumber2 == 20 || userNumber2 == 40)
            {
                Console.WriteLine("Your Number is 20 or 40");
            }
            else
            {
                
            }
        }

        public void IfAndIfelseStatementExample()
        {
            int number = -10;

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        #endregion
    }
}

