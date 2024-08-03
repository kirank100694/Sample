using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.ExplicitInterfaceImplimentation
{
    /// <summary>
    /// If a class implements two interfaces that contain a member with the same signature, 
    /// then implementing that member on the class will cause both interfaces to use that member as their implementation. 
    /// </summary>
    interface Explicit1
    {
        void InterfaceMethod();
    }
    interface Explicit2
    {
        void InterfaceMethod();
    }

    class ExplicitInterface : Explicit1, Explicit2 
    {
        void Explicit1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method Implimented");
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method Implimented");
        }

        void Explicit2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method Implimented");
        }
    }
}
