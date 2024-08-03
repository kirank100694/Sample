using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.MethodHiding
{
    #region MethodHiding Example1
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }
    #endregion

    #region MethodHiding Example2
    public class BaseClass
    {
        public void StaticMethod()
        {
            Console.WriteLine("Base static method");
        }
    }

    // Derived class hiding the static method of base class
    public class DerivedClass : BaseClass
    {
        public new void StaticMethod()
        {
            Console.WriteLine("Derived static method");
        }
    }
    #endregion
}
