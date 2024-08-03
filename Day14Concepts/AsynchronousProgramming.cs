using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day14Concepts
{
    public static class AsynchronousProgramming
    {
        /// <summary>
        /// Task t1 = new Task(Fun1); "Does not have Thread affinity" 
        /// t1.Start(); "Start executing Fun1 Parallely"
        /// t2.Start();  "Starts executing Fun2 Parallely"
        /// Console.WriteLine("Hello World!");  "Executing main Parallely"
        /// </summary>
        public static void DisplayAsychronous()
        {
            //Thread t1 = new Thread(new ThreadStart(Fun1));
            //Task t1 = new Task(Fun1);
            //Thread t2 = new Thread(new ThreadStart(Fun2));
            //Task t2 = new Task(Fun2);
            //t1.Start();
            //t2.Start();
            Fun1();
            Fun2();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static async void Fun1()
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Fun 1 :- " + i);
            }
        }
        static async void Fun2()
        {
            for (int i = 0; i <100000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Fun 2 :- " + i);
            }
        }
    }
}
