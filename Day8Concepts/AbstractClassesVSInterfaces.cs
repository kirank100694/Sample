using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.AbstractClassesVSInterfaces
{
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
