using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class ForAndForeachLoop
    {
        #region ForAndForeachLoopExamples
        /// <summary>
        /// ForLoop: Is very similar to while loop in a while loop we do the initalization at one place 
        ///          Condition check at another place, and modifying the variables at another place
        ///          Where as for loop has all of these at one place.
        /// ForeachLoop: Is used to iterate through the items in a collection.
        ///              For EX.. each loop can be used with arrays or collections such as array list HashTable & Generics.
        /// </summary>
        public void ForAndForeachLoopExample1()
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

            Console.WriteLine(" ");

            //ForLoop
            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }

            Console.WriteLine(" ");

            //ForeachLoop
            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            //Break And Continue
            for (int i1 = 1; i1 <= 20; i1++)
            {
                Console.Write(i1);
                if (i1 == 10)
                    break;
            }

            Console.WriteLine(" ");

            for (int i2 = 0; i2 <= 20; i2++)
            {
                if (i2 % 2 == 1)
                    continue;
                Console.WriteLine(i2);
            }
        }

        public void ForAndForeachLoopExample2() 
        {
            int j = 0;

            for (int i = 1; i <= 5; i++)
            {
                j = j + i;

                Console.WriteLine(j);
            }

            int[] numbers = new int[] { 0, 1, 2, 3, 5, 8, 13 };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
    }
}
