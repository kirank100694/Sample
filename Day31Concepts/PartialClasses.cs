using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.PartialClasses
{
    /// <summary>
    /// Multiple developers can work simultaneously with asingle class in separate files.
    /// </summary>
    public partial class Helloclass
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public partial class Helloclass
    {
        public void HelloUniverse()
        {
            Console.WriteLine("Hello Universe!");
        }
    }

    public partial class Helloclass
    {
        public void HelloUser()
        {
            Console.WriteLine("Hello User!");
        }
    }
}

