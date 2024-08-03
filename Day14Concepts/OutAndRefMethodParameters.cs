using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts
{
    public class OutAndRefMethodParameters
    {
        public static void DisplayOutAndRef()
        {
            int outsidevar = 20;
            //SomeFunction(outsider);
            //SomeFunction(ref outsider);
            SomeFunction(out outsidevar);


            Console.WriteLine(outsidevar);
        }

        public static void SomeFunction(out int Insidevar)
        {
            Insidevar = 0;
            Insidevar = Insidevar + 10;
        }
    }
}
