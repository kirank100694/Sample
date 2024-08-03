using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.IntroductionToInterface
{
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
            Console.WriteLine("Print2");
        }
        public void Print1()
        {
            Console.WriteLine("Print1");
        }
    }

    public class Sample
    {

    }
}
