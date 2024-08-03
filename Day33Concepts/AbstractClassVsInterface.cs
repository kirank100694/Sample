using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.AbstractClassVsInterface
{
    /// <summary>
    /// Abstract class can have implementations for some of the methods, but the interface can not have implementation for any of it's members.
    /// Interface cna not have fields where as abstract class can have fields.
    /// </summary>
    public abstract class Customer
    {
        int ID;
        public void Print()
        {
            Console.WriteLine("Print");
        }
        public interface ICustomer 
        {
            public void Print()
            {
                Console.WriteLine("Print");
            }
        }
    }
}
