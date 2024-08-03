using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts
{
    /// <summary>
    /// DataTypes   => Datatypes specifice the size and type of the value that can be stored,Save time and memory
    /// Types       => ValueType    : int,long,float,double,decimal,char,boolean,byte,struct,enum etc..
    ///                ReferenceType: string,object,arrays,classes,Delegates,Interfacec etc..
    /// </summary>
    class BuiltInDetaTypes
    {
        #region ValueDataTypes
        public void ValueDataTypes()
        {
            // Int, Long
            int maxValueOfInt = 2147483647;
            Console.WriteLine(maxValueOfInt);

            long maxValueOfLong = 9223372036854775807;
            
            Console.WriteLine(maxValueOfLong);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // Float,  double, decimal
            float number1 = 23.45f;
            Console.WriteLine(number1);

            double number2 = 23.5;
            Console.WriteLine(number2);

            decimal number3 = 23.5m;
            Console.WriteLine(number3);

            Console.Write($"Size of float is {sizeof(float)}\n");
            Console.WriteLine($"Max value Of float is{int.MaxValue}");
            Console.WriteLine($"Min value Of float is{int.MinValue}\n");

            Console.Write($"Size of double is {sizeof(double)}\n");
            Console.WriteLine($"Max value Of double is{double.MaxValue}");
            Console.WriteLine($"Min value Of double is{double.MinValue}\n");

            Console.Write($"Size of decimal is {sizeof(decimal)}\n");
            Console.WriteLine($"Max value Of decimal is{decimal.MaxValue}");
            Console.WriteLine($"Min value Of decimal is{decimal.MinValue}\n");

            //boolean, char

            bool valid = true;
            Console.WriteLine(valid);

            bool invalid = false;
            Console.WriteLine(invalid);

            char character = 'a';
            Console.WriteLine(character);
        }
        #endregion

        #region ReferenceDataType
        public void ReferenceDataTypes()
        {
            string name = "Welcome to our Family";
            Console.WriteLine(name);

            string password = "Family!@#123";
            Console.WriteLine(password);

            long number = 1200;
            Console.WriteLine(number);
        }
        #endregion

        #region ReferenceDataTypesExample
        public void ReferenceDataTypesExample()
        {
            string name = "Savar ";

            name += "Technologies ";
            name = name + "Pvt.Ltd.";
            
            Console.WriteLine(name);

            object target = 20;
            Console.WriteLine(target);
        }
        #endregion
    }
}
