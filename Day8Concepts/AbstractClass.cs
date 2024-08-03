using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.AbstractClass
{
    /// <summary>
    /// public abstract sealed class Customer
    /// </summary>
    public abstract class Customer 
    {
        public abstract void Print();

        public void Print1()
        {
            Console.WriteLine("Print1");
        }
        
    }
    public class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }
}
