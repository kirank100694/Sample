using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.Generics
{
    public class Calculator<T>
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(object value1, object value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
