using Day39Concepts.EmployeeClass;
using Day39Concepts.EmployeeTestDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace Day39Concepts.SortingOperatorsTypes
{
    /// <summary>
    /// Sorting is used to manage in a particular order.
    /// Order may be asending or desending.
    /// Order may be int based or any other datatype based
    /// There are 5 methods in sortingOperators:
    /// 1. OrderBy
    /// 2. OrderByDecending
    /// 3. ThenBy
    /// 4. ThenByDecending
    /// 5. Reverse
    /// </summary>
    public class SortingOperators
    {
        public void OrderByMethod()
        {
            List<int> dataSourceInt = EmployeeTestData.GetSortingOperatorsType();

            var querySyntax = (from number in dataSourceInt
                               where number > 10
                               orderby number
                               select number).ToList();

            var methodSyntax = dataSourceInt.Where(number => number > 10).OrderBy(number => number).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OrderByMethodExample()
        {
            List<int> dataSourceInt = EmployeeTestData.GetSortingOperatorsType();

            List<String> dataSourceString = EmployeeTestData.GetSortingOperatorsTypes();

            var methodSyntax = dataSourceString.Where(name => name.Length > 6).OrderBy(name => name).ToList();

            var querySyntax = (from name in dataSourceString
                               where name.Length > 6
                               orderby name
                               select name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OrderByMethodComplexExample()
        {
            List<Employee> dataSource = EmployeeTestData.GetOrderByMethodExample();

            var methodSyntax = dataSource.Where(employee => employee.Id > 2).OrderBy(employee => employee.Name).ToList();

            var quarySyntax = (from employee in dataSource
                               where employee.Id > 2
                               orderby employee.Id
                               select employee).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine("Employee Name : {0}", item.Name);
            }

            Console.ReadLine();
        }

        
        public void OrderByDescendingMethod()
        {
            List<int> dataSourceInt = EmployeeTestData.GetSortingOperatorsType();

            var methodSyntax = dataSourceInt.Where(number => number > 10).OrderByDescending(number => number).ToList();

            var querySyntax = (from number in dataSourceInt
                               where number > 20
                               orderby number descending
                               select number).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OrderByDescendingMethodExample()
        {
            List<String> dataSourceString = EmployeeTestData.GetSortingOperatorsTypes();

            var methodSyntax = dataSourceString.OrderByDescending(name => name).ToList();

            var querySyntax = from name in dataSourceString
                              orderby name descending
                              select name;

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OrderByDecendingMethodComplexExample()
        {
            List<Employee> dataSource = EmployeeTestData.GetOrderByMethodExample();

            var methodSyntax = dataSource.OrderByDescending(employee => employee.Id).ToList();

            var querySyntax = (from employee in dataSource
                      orderby employee.Id descending
                      select employee).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"Order = {item.Id}, name = {item.Name}, Email = {item.Email}");
            }

            Console.ReadLine();
        }

        public void ThenByMethod()
        {
            List<Student> studentList = EmployeeTestData.GetThenByMethod();

            var methodSyntax = studentList.OrderBy(student => student.StudentName).ThenBy(student => student.Age);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void ThenByDecendingMethod()
        {
            List<Student> studentList = EmployeeTestData.GetThenByMethod();

            var methodSyntax = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            foreach (var result in methodSyntax)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }


        public void ReverseMethod()
        {
            int[] rollnumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = rollnumbers.Reverse().ToList();

            var querySyntax = (from number in rollnumbers
                               select number).Reverse();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void ReverseMethodExample()
        {
            List<string> names = new List<string>() { "Mark", "John", "Adam", "Umar", "Bob" };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("================");

            var reversed = names.AsEnumerable().Reverse();

            var reverse = names.AsQueryable().Reverse();

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
