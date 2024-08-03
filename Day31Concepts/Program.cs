using System;
using Day31Concepts.NameSpaces;
using Customer = Day31Concepts.ClassIntroduction;
using Day31Concepts.StaticAndInstanceMembers;
using Day31Concepts.TypesAndTypeMembers;
using Private = Day31Concepts.AccessModifiers;
using Protected = Day31Concepts.AccessModifiers;
using Day31Concepts.PartialClasses;

namespace Day31Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeDepartment();
            //Payrole();
            //StudentDepartment();
            //ClassIntroduction();
            //StaticAndInstanceMembers();
            //PrivateAndPublic();
            //Protected();
            //Helloworld();
        }

        public static void EmployeeDepartment()
        {
            EmployeeDepartment employeeDepartment = new EmployeeDepartment();
            employeeDepartment.DisplayDepartmentinfo();
        }

        public static void Payrole()
        {
            Payrole payrole = new Payrole();
            payrole.DisplayPayroleInfo();
        }

        public static void StudentDepartment()
        {
            StudentDepartment studentDepartment = new StudentDepartment();
            studentDepartment.DisplayDepartmentinfo();
        }

        public static void ClassIntroduction()
        {
            Customer.Customer customer = new Customer.Customer("Savar", " Technologies");
            customer.PrintFullName();

            Customer.CustomerInfo customerInfo = new Customer.CustomerInfo(); //"K", "k"
            customerInfo.PrintFullName();
        }

        static void StaticAndInstanceMembers()
        {
            Member member = new Member(5);
            float Area = member.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            Member member1 = new Member(6);
            float Area1 = member1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle circle = new Circle(5);
            float Area2 = member.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            Circle circle1 = new Circle(6);
            float Area3 = member1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            //Static Constuctor
            Round round = new Round(5);
            float Area4 = member.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            //Instance Constuctor
            Round round1 = new Round(6);
            float Area5 = member1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            //Public Static Constuctor
            Console.WriteLine(Round._PI);
        }

        private static void PrivateAndPublic()
        {
            Private.Customer customer = new Private.Customer();
            Console.WriteLine(customer.ID);
        }

        private static void Protected()
        {
            Protected.Customer customer = new Protected.Customer();
            Console.WriteLine(customer.ID);
        }

        public static void Helloworld()
        {
            Helloclass helloclass = new Helloclass();
            helloclass.HelloWorld();
            helloclass.HelloUniverse();
            helloclass.HelloUser();
        }
    }
}
