using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.AbstractClasses
{
    /// <summary>
    /// The abstract keyword is used to create abstract classes.
    /// An abstract class is incomplete and hence can not be instantiated.
    /// An abstract class can only be used as base class.
    /// An abstract class can not be sealed.
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

    public class Abstract : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }
}
