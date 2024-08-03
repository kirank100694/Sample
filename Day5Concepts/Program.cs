using System;
using employee = Day5Concepts.EmployeeManagment;
using Day5Concepts.EmployeeManagment.Payrole;
using student = Day5Concepts.StudentManagment;
using FullName = Day5Concepts.ClassIntroduction;
using Day5Concepts.StaticAndInstanceMembers;

namespace Day5Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagment();
            StudentManagment();
            ClassIntroduction();
            StaticAndInstanceMembers();
        }

        static void EmployeeManagment()
        {
            employee.Department employeeDepartment = new employee.Department();
            employeeDepartment.DisplayDepartmentinfo();

            Payrole Payrole = new Payrole();
            Payrole.DisplayPayroleInfo();
        }

        static void StudentManagment()
        {
            student.Department studentDepartment = new student.Department();
            studentDepartment.DisplayDepartmentinfo();
        }

        static void ClassIntroduction()
        {
            FullName.Customer C = new FullName.Customer("Savar", " Technologies");
            FullName.CustomerInfo CI = new FullName.CustomerInfo("K", "k");
            CI.PrintFullName();
            C.PrintFullName();
        }

        static void StaticAndInstanceMembers()
        {
            Member M = new Member(5);
            float Area = M.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            Member M1 = new Member(6);
            float Area1 = M1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            Circle C = new Circle(5);
            float Area2 = M.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            Circle C1 = new Circle(6);
            float Area3 = M1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            //Static Constuctor
            Round R = new Round(5);
            float Area4 = M.CalculateArea();
            Console.WriteLine("Area = {0}", Area);

            //Instance Constuctor
            Round R1 = new Round(6);
            float Area5 = M1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);

            //Public Static Constuctor
            Console.WriteLine(Round._PI);
        }
    }
}
