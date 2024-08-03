using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.ExplicitInterfaceImplimentation
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }

    class Program : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method Implimented");
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method Implimented");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method Implimented");
        }
    }
   
}
