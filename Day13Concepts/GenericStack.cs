using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.GenericStack
{
    public class GenericStackConcepts
    {
        public static void StackConcept()
        {
            var stack = new Stack<string>();
            stack.Push("Item1");
            stack.Push("Item2");
            stack.Push("Item3");

            var popedItem = stack.Pop();

            var peekedValue = stack.Peek();
            
            stack.Clear();

            Console.ReadKey();
        }
    }
}
