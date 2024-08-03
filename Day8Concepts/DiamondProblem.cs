using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.DiamondProblem
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }
    class D : A
    {
        public override void Print()
        {
            Console.WriteLine("D Implementation");
        }
    }
}
