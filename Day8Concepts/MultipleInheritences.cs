using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.MultipleInheritences
{
    interface IA
    {
        void AMethod();
    }
    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void BMethod();
    }
    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }
    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void AMethod()
        {
            a.AMethod();
        }
        public void BMethod()
        {
            b.BMethod();
        }
    }
}
