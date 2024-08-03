using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.Inheritance
{
    /// <summary>
    /// Public Class And Parent Class Example
    /// </summary>
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }
        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived Class Constructor Called ")
        {
            Console.WriteLine("ChildClass Construtor Called");
        }
    }
}
