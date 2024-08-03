using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.Interfaces
{
    /// <summary>
    /// We create interfaces using interface keyword. Just like classes interfaces also contains
    /// properties, methods, delegates but only declarations no implementation.
    /// It is a compile time error to provide implementations for any interface member.
    /// </summary>
    interface ICustomer1
    {
        void Print1();
    }
    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer : ICustomer2
    {
        public void Print2()
        {
            Console.WriteLine("Kiran");
        }
        public void Print1()
        {
            Console.WriteLine("Savar");
        }
    }

    interface Iindia
    {
        void FamousDish(); 
    }

    class Hyderabad : Iindia
    {
        public void FamousDish()
        {
            Console.WriteLine("Hyderabad FamousDish is : Biryani");
        }
    }
}
