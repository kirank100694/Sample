using System;
using Inheritance = Day6Concepts.Inheritance;
using MethodHiding = Day6Concepts.MethodHiding;
using Polymeorphism = Day6Concepts.Polymeorphism;
using Day6Concepts.MethodOverridingAndOverHiding;
using Day6Concepts.MethodOverLoading;
using System.ComponentModel;

namespace Day6Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            InheritanceExample();
            MethodHiding();
            Polymeorphims();
            MethodOverridingAndOverHiding();
            MethodOverLoading();
        }

        public static void InheritanceExample()
        {
            Inheritance.FullTimeEmployee FTE = new Inheritance.FullTimeEmployee();
            FTE.FirstName = "Saver";
            FTE.LastName = "Tech";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            Inheritance.PartTimeEmployee PTE = new Inheritance.PartTimeEmployee();
            PTE.FirstName = "Kiran";
            PTE.LastName = "Tech";
            PTE.PrintFullName();

            Inheritance.ChildClass CC = new Inheritance.ChildClass();
        }

        public static void MethodHiding()
        {
            MethodHiding.FullTimeEmployee FTE = new MethodHiding.FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();

            MethodHiding.PartTimeEmployee PTE = new MethodHiding.PartTimeEmployee();
            //MethodHiding.Employee PTE = new HalfdayTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            PTE.PrintFullName();
            //((MethodHiding.Employee)HTE).PrintFullName();
        }

        public static void Polymeorphims()
        {
            Polymeorphism.Employee[] Employees = new Polymeorphism.Employee[4];

            Employees[0] = new Polymeorphism.Employee();
            Employees[1] = new Polymeorphism.FullTimeEmployee();
            Employees[2] = new Polymeorphism.PartTimeEmployee();
            Employees[3] = new Polymeorphism.TemporaryEmployee();

            foreach (Polymeorphism.Employee e in Employees)
            {
                e.PrintFullName();
            }
        }

        public static void MethodOverridingAndOverHiding()
        {
            //BaseClass B = new DerivedClass();
            BaseClass B = new BaseClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();
            //D.Print1();
        }

        public static void MethodOverLoading()
        {
            
        }
    }
}

