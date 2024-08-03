using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts
{

    internal class NullCoalescingOperator
    {
        #region NullableTypeExample
        /// <summary>
        /// The null coalescing operator (??) is used to provide a default 
        /// value for a nullable type or reference type that may be null.
        /// </summary>
        public void NullableTypeExample()
        {
            string strNumber = null;
            string value = strNumber ?? "Savar";
            Console.WriteLine(value);

            Nullable<int> number = null;
            Console.WriteLine(number);

            int? number1 = null;
            int value1 = number1 ?? 25;
            Console.WriteLine(value1);

            long? number2 = null;
            Console.WriteLine(number2);

            bool? bool3 = true;
            Console.WriteLine(bool3);
        }
        #endregion

        #region NullCoalescingOperatorExample
        /// <summary>
        /// The null coalescing operator "??" is a handy binary operator 
        /// that returns its left-hand operand as it is if not null, and otherwise its right-hand operand.
        /// </summary>
        public void NullCoalescingOperatorExample()
        {
            bool? AreYouMajor = null;

            AreYouMajor = false;
            Console.WriteLine($"Are you Major: {AreYouMajor}");

            AreYouMajor = true;
            Console.WriteLine($"Are you Major ? {AreYouMajor}");
        }
        #endregion
    }
}
