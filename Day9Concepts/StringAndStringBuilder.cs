using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.StringAndStringBuilder
{
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
