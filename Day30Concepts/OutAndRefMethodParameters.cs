using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class OutAndRefMethodParameters
    {
        #region OutAndRefExample1
        /// <summary>
        /// Out&Ref are c# keywords helps to pass variables by reference
        /// By default variables are passed by REF to methods and functions
        /// </summary>
        public void OutAndRefExample1()
        {
            int outSideVar = 20;

            SomeFunction(outSideVar);

            Console.WriteLine(outSideVar);
        }

        public void SomeFunction(int inSideVar)
        {
            inSideVar = inSideVar + 10;
        }
        #endregion

        #region OutAndRefExample2
        public void OutAndRefExample2()
        {
            int outSideVar = 20;
            Function(ref outSideVar);


            Console.WriteLine(outSideVar);
        }

        public static void Function(ref int inSideVar)
        {
            inSideVar = inSideVar + 10;
        }
        #endregion

        #region OutAndRefExample3
        public void OutAndRefExample3()
        {
            int outSideVar = 20;
            AnotherFunction(out outSideVar);

            Console.WriteLine(outSideVar);
        }

        public static void AnotherFunction(out int inSideVar)
        {
            inSideVar = 0;
            inSideVar = inSideVar + 10;
        }
        #endregion
    }
}
