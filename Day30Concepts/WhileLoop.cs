using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class WhileLoop
    {
        #region WhileLoop
        /// <summary>
        /// 1.While loop checks the condition first.
        /// 2.If condition is true statements with in the loop are executed.
        /// 3.This process is repeated as long as the condition evaluates to true.
        /// </summary>
        public void WhileLoopExample()
        {
            Console.WriteLine("Please enter your target?");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget )
            {
                Console.Write( start +" ");
                start = start + 2;
            }
        }
        #endregion
    }
}
