using System;

namespace Day29Concepts
{
    internal class Arrays
    {
        #region Arrays
        /// <summary>
        /// Arrays are used to store multiple values in a single variable, 
        /// instead of declaring separate variables for each value.
        /// To declare an array, define the variable type with square brackets "[]"
        /// </summary>
        public void IntegerArraysExample()
        {
            int employeeId1 = 25;
            int employeeId2 = 40;
            int employeeId3 = 65;
            int employeeId4 = 98;
            int employeeId5 = 100;

            Console.WriteLine(employeeId1);
            Console.WriteLine(employeeId2);
            Console.WriteLine(employeeId3);
            Console.WriteLine(employeeId4);
            Console.WriteLine(employeeId5);

            //Integer Array Declaration
            int[] employeeIds = new int[5];
            //decimal[] employeeIds1 = new decimal[5];//to do

            //Intialization
            employeeIds[0] = 25;
            employeeIds[1] = 40;
            employeeIds[2] = 65;
            employeeIds[3] = 98;
            employeeIds[4] = 100;

            Console.WriteLine(employeeIds[0]);
            Console.WriteLine(employeeIds[1]);
            Console.WriteLine(employeeIds[4]);

            //Intialization And Declaration
            var employeeIds1 = new int[2] { 25, 45 };
            int[] employeeIds2 = new int[] { 25, 45, 65, 98, 100, 222, 333, 444, 555 };
            int[] employeeIds3 = { 25, 45, 65, 98, 100, 222, 333, 444, 555, 666 };

            Console.WriteLine(employeeIds1[1]);
            Console.WriteLine(employeeIds2[7]);
            Console.WriteLine(employeeIds3[4]);
        }
        #endregion

        public void StringArrayExample()
        {
            string[] employeeNames = new string[4];

            //Intialization
            employeeNames[0] = "Rahul";
            employeeNames[1] = "Ravi";
            employeeNames[2] = "Venu";
            employeeNames[3] = "Kiran";

            Console.WriteLine(employeeNames[3]);

            string[] employeeNames1 = new string[4] { "Rahul", "Ravi", "Venu", "Kiran" };
            string[] employeeNames2 = new string[] { "Rahul", "Ravi", "Venu", "Kiran", "rakesh", "Raghu", "Raghav" };
            string[] employeeNames3 = { "Rahul", "Ravi", "Venu", "Kiran", "kk", "RR" };

            Console.WriteLine(employeeNames1[2]);
            Console.WriteLine(employeeNames2[1]);
            Console.WriteLine(employeeNames3[3]);
        }

        public void DecimalArrayExample()
        {
            decimal[] decemalNumbers = new decimal[5];

            decemalNumbers[0] = (decimal)1.25;
            decemalNumbers[1] = (decimal)5.25;
            decemalNumbers[2] = (decimal)12.45;
            decemalNumbers[3] = (decimal)4.34;
            decemalNumbers[4] = (decimal)7.45;

            Console.WriteLine(decemalNumbers[2]);

            decimal[] price = { (decimal)55.25, (decimal)59.25, (decimal)122.45, (decimal)48.34, (decimal)79.45 };

            Console.WriteLine(price[4]);
        }
    }
}
