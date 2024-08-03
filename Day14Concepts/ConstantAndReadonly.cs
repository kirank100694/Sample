using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts
{
    public class ConstantAndReadonly
    {
        //readonly int a;
        static int num = 0;

        public ConstantAndReadonly()
        {
            //a = 50;
            //Console.WriteLine(a);

            num++;
            Console.WriteLine("For first object : " + num );
        }

        public static void DisplayConstant()
        {
            //const int a = 100;
            //Console.WriteLine(a);

            //ConstantAndReadonly C = new ConstantAndReadonly();
            ConstantAndReadonly C1 = new ConstantAndReadonly();
            ConstantAndReadonly C2 = new ConstantAndReadonly();
            ConstantAndReadonly C3 = new ConstantAndReadonly();
            ConstantAndReadonly C4 = new ConstantAndReadonly();
        }
    }
}
