using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class SelectInProjectionOperator
    {
        public static void DisplayBasicQueryInProjectionOperator()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id=1, Name="Tom", Email="tom@gmail.com" },
                new Employee() { Id=2, Name="John", Email="john@gmail.com" },
                new Employee() { Id=3, Name="Mark", Email="mark@gmail.com" },
                new Employee() { Id=4, Name="Kim", Email="kim@gmail.com" },
                new Employee() { Id=5, Name="Adam", Email="adam@gmail.com" },
            };

            var basicQuery = (from emp in employees
                              select emp).ToList();

            var basicMethod = employees.ToList();

            var basicPropQuery = (from emp in employees
                                  select emp.Id.ToString()).ToList();

            var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }

            Console.ReadLine();
        }

        public static void DisplaySelectInProjectionOperator()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id=1, Name="Tom", Email="tom@gmail.com" },
                new Employee() { Id=2, Name="John", Email="john@gmail.com" },
                new Employee() { Id=3, Name="Mark", Email="mark@gmail.com" },
                new Employee() { Id=4, Name="Kim", Email="kim@gmail.com" },
                new Employee() { Id=5, Name="Adam", Email="adam@gmail.com" },
            };

            var SelectQuery = (from emp in employees
                               select new Employee()
                               {
                                   Id = emp.Id,
                                   Email = emp.Email
                               }).ToList();

            var SelectQuerys = (from emp in employees
                               select new
                               {
                                   CustomId = emp.Id,
                                   CustomName = emp.Name,
                                   CustomEmail = emp.Email
                               }).ToList();

            var SelectMethod = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                FullName = emp.Name,
                StEmail = emp.Email
            }).ToList();

            var SelectMethods = employees.Select(emp => new
            {
                CustomId = emp.Id,
                CustomName = emp.Name,
                CustomEmail = emp.Email
            }).ToList();

            foreach (var item in SelectQuerys)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }

            Console.ReadLine();
        }

        public static void DisplayIndeQueryOperator()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id=1, Name="Tom", Email="tom@gmail.com" },
                new Employee() { Id=2, Name="John", Email="john@gmail.com" },
                new Employee() { Id=3, Name="Mark", Email="mark@gmail.com" },
                new Employee() { Id=4, Name="Kim", Email="kim@gmail.com" },
                new Employee() { Id=5, Name="Adam", Email="adam@gmail.com" },
            };

            var query = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

            Console.ReadLine();
        }
    }
}
