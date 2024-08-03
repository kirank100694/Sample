using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.MethodOverLoading
{
    public class MethodOverLoadingExample
    {
        /// <summary>
        /// Value Parameter
        /// </summary>
        /// <param name="FN"></param>
        /// <param name="SN"></param>
        /// <param name="TN"></param>
        public void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        /// <summary>
        ///Output Parameter
        /// </summary>
        /// <param name="FN"></param>
        /// <param name="SN"></param>
        /// <param name="Sum"></param>
        public void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            Sum = FN + SN;
        }

        /// <summary>
        ///  Using Params Keyword
        ///  It is not posible To Overload Methods Based on the Peram keyword
        /// </summary>
        /// <param name="FN"></param>
        /// <param name="SN"></param>
        /// <param name="TN"></param>
        public void Add(int FN, int SN, params int[] TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add1(int FN, int SN, int[] TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

    }
}
