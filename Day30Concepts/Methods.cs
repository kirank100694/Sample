using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    public class Methods
    {
        /// <summary>
        /// 1.Methods are called as functions these terms are used interchangeably.
        /// 2.Methods are extremely useful because they allow you to define 
        /// your logic once and use it at many place.
        /// 3.Methods make the maintenance of our application easier.
        /// </summary>
        public static void MethodExample1()
        {
            //Static
            Methods P = new Methods();
            P.EvenNumbers();
        }

        //Instance
        public void EvenNumbers()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static void MethodExample2()
        {
            Methods.EvenNumber(40);

            Methods p = new Methods();
            int sum = p.Add(10, 30);

            Console.WriteLine("Sum= {0}", sum);
        }

        public int Add(int firstNumber, int secondNunber)
        {
            return firstNumber + secondNunber;
        }

        public static void EvenNumber(int Target)
        {
            int start = 0;

            while (start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
