using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.Generics
{
    /// <summary>
    /// 1.Generic class are extensively used by collection classes available in system.Collection.Generics namespace.
    /// 2.One way of making areequal() method reusable is to use object type parameters.
    /// Since every type in .net directly or indirectly inherit from system.
    /// Objecttype areequal() method works with any datatype, but the problem is performace
    /// degradation due to oxing and unboxing happening.
    /// 3.Also equal() method is no longer type safe.
    /// </summary>
    public class Calculator<Customer>
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(object value1, object value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(Customer value1, Customer value2)
        {
            return value1.Equals(value2);
        }
    }
}
