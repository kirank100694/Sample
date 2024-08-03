using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.ConstantAndReadonly
{
    /// <summary>
    /// Constant:
    /// 1.A variable declared as Const must be assigned a value at declaration.
    /// 2.We cannot change if once it is assigend
    /// 3.Thet are implicitly static by default
    /// 4.We can apply Const keyword to built in value type(int, long, short, byte, char, float etc ) or 
    /// Referance type which can be assigned with a value null.
    /// ReadOnly:
    /// 1.The value will be initialized either at declaration time or in the Constructor
    /// 2.Readonly values will evaluate at runtime only.
    /// </summary>
    public class ConstantAndReadonlyExample
    {
        readonly int value;
        static int number = 0;

        public ConstantAndReadonlyExample()
        {
            value = 50;
            Console.WriteLine(value);

            number++;
            Console.WriteLine("For first object : " + number);
        }
    }
}
