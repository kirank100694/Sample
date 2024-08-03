using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts
{
    class Variables
    {
        static int userNumber = 1234;  //global variable
        static string userName = "Saver";
        static long value = 10;

        #region Display localVariables And globalvariables
        public void DisplayVariables()
        {
            int userNumber = 1234; // local variable
            Console.WriteLine(userNumber);

            string userName = "Saver";
            Console.WriteLine(userName);

            long value = 10;
            Console.WriteLine(value);
        }

        public void VariableTestMethod()
        {
            Console.WriteLine(userNumber);

            Console.WriteLine(userName);

            Console.WriteLine(value);
        }
        #endregion
    }
}
