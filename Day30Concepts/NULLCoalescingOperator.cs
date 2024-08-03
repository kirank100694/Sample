using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class NULLCoalescingOperator
    {
        #region NULLCoalescingOperatorSimpleExample
        /// <summary>
        /// Coalescing Operators returns the first non-null value from a chain.
        /// </summary>
        public void NULLCoalescingOperatorSimpleExample()
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = "str4";

            string final = str1 ?? str2 ?? str3 ?? str4;
            Console.WriteLine(final);
        }
        #endregion

        #region NULLCoalescingOperatorComplexExample
        public void NULLCoalescingOperatorComplexExample()
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = "str4";

            string final = "";
            if (str1 != null)
            {
                final = str1;
            }
            else
            {
                if (str2 != null) 
                {
                    final = str2;
                }
                else
                {
                    if (str3 != null)
                    {
                        final = str3;
                    }
                    else
                    {
                        if (str4 != null)
                        {
                            final = str4;
                        }
                    }
                }
            }
            Console.WriteLine(final);
        }
        #endregion
    }
}
