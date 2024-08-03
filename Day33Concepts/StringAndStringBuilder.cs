using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.StringAndStringBuilder
{
    /// <summary>
    /// System.String is Immutable.
    /// System.Builder is Mutable
    /// String builder objects are mutable, they offer better performance than string objects of type system.string,
    /// when heavy string manipulation is involved.
    /// </summary>
    public class StringAndStringBuilder
    {
        public StringAndStringBuilder()
        {
            string userString = "C# ";
            userString += "Videos ";
            userString += "Tutorial ";
            userString += "for ";
            userString += "Beginners ";
            Console.WriteLine(userString);

            StringBuilder userstring = new StringBuilder();
            userstring.Append("C# ");
            userstring.Append("Videos ");
            userstring.Append("Tutorial ");
            userstring.Append("for ");
            userstring.Append("Beginners ");
            Console.WriteLine(userString.ToString());
        }
    }
}
