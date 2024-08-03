using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Inheritance
{
    #region Inheritance Example1
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

    //Derived class
    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    //Derived class
    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    //Derived class
    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived Class Constructor Called ")
        {
            Console.WriteLine("ChildClass Construtor Called");
        }
    }
    #endregion

    #region Inheritance Example2
    public class Person
    {
        public string Name { get; set; }
        public string Company { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    // Derived class
    public class Employees : Person
    {
        public void Displayinfo()
        {
            Console.WriteLine($"{Name} is Working in: {Company}");
        }
    }

    // Derived class
    public class Manager : Employees
    {
        public void Manage()
        {
            Console.WriteLine($"{Name} managing the team of {Company}");
        }
    }
    #endregion
}
