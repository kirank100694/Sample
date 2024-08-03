using System;

namespace Day29Concepts
{
    /// <summary>
    /// DataTypeConversion is the process of converting a value of one data type to another data type.
    /// Types   : Implicit Conversion => No data loss
    ///         : Explicit Conversion => Some data loss
    /// </summary>
    internal class DataTypeConversion
    {
        #region ImplicitConversion And Example
        /// <summary>
        /// Implicit conversions are performed by a type-safe manner.
        /// </summary>
        public void ImplicitConversion()
        {
            int intValue = 100;
            Console.WriteLine(intValue);

            long longValue = intValue;
            Console.WriteLine(longValue);

            float floatValue = intValue;
            Console.WriteLine(floatValue);
        }

        public void ImplicitConversionExample()
        {
            float floatValue = 5.1245f;

            double doubleValue = floatValue; 
            Console.WriteLine(doubleValue);

            byte byteValue = 100;
            int intValue = byteValue; 
            Console.WriteLine(intValue);
        }
        #endregion

        #region ExplicitConversion And Example
        /// <summary>
        /// Explicit conversions are done explicitly by users using the pre-defined functions.
        /// Types   : Typecast Operator
        ///         : Covertclass Operater
        /// </summary>
        public void ExplicitConversion()
        {
            float floatValue = 123.45F;
            Console.WriteLine(floatValue);
            Console.WriteLine("After conversion");

            int intValue1 = (int)floatValue;   //Typecast Operator
            Console.WriteLine(intValue1);

            long longValue1 = (long)floatValue; //Typecast Operator   
            Console.WriteLine(longValue1);

            int intValue2 = Convert.ToInt32(intValue1); //Convertclass Operator
            Console.WriteLine(intValue2);

            long longValue2 = Convert.ToInt32(longValue1);  //Convertclass Operator
            Console.WriteLine(longValue2);

            long longValue3 = long.MaxValue;
            Console.WriteLine(longValue3);

            int intValue3 = (int)longValue3;    //Typecast Operator
            Console.WriteLine(intValue3);

            int intValue4 = Convert.ToInt32(longValue3);    //Convertclass Operator
            Console.WriteLine(intValue4);
        }

        public void ExplicitConversionExample()
        {
            int intValue1 = 500;
            byte byteValue = (byte)intValue1; //Typecast Operator
            Console.WriteLine(byteValue);

            double doubleValue = 5.21;
            int intValue2 = (int)doubleValue; //Typecast Operator
            Console.WriteLine(intValue2);

            int intValue3 = 255;
            byte byteValue1 = Convert.ToByte(intValue3); //Convertclass Operator
            Console.WriteLine(byteValue1);

            double doubleValue1 = 5.21;
            int intValue4 = Convert.ToInt32(doubleValue1); //Convertclass Operator
            Console.WriteLine(intValue4);
        }
        #endregion
    }
}
