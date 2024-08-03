using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts
{
    public class GenericQueue
    {
        public static void DisplayQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");

            var task = queue.Dequeue();

            var peekedItask = queue.Peek();
            queue.Clear();
            Console.ReadKey();

        }
    }
}
