using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.MethodOverridingVSOverHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I Am A Base Class Print Method");
        }
    }

    /// <summary>
    /// OverRiding and OverHiding
    /// </summary>
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I Am A Derived Class Print Method");
        }
    }
}
