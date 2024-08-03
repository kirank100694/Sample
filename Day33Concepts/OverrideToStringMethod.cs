using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.OverrideToStringMethod
{
    /// <summary>
    /// Every class implicitly inherits the Object class. 
    /// Therefore, every object gets the ToString method, which returns a string representation of that object. 
    /// For example, all variables of type int have a ToString method, which enables them to return their contents as a string
    /// </summary>
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return lastName + " " + firstName;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string departmentName { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + departmentName;
        }
    }
}
