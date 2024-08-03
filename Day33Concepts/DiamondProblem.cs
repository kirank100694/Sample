using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.DiamondProblem
{
    /// <summary>
    /// 1.Class B and C inherit from class A.
    /// 2.Class D inherits from both B and C.
    /// 3.If a method in C calls a method defined in A and does not override the method, 
    /// and B and C have override that method differently.
    /// </summary>
    class Apple
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }
    class Banana : Apple
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    class Carrot : Apple
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }
    class Dates : Apple
    {
        public override void Print()
        {
            Console.WriteLine("D Implementation");
        }
    }
}
