using System;
using Day39Concepts.EmployeeClass;
using Day39Concepts.EmployeeTestDataClass;
using System.Collections.Generic;
using System.Linq;

namespace Day39Concepts.FilteringOperatorsTypes
{
    /// <summary>
    /// Filtering operators are process to get only those elements from a data source who satisfy a specified condition.
    /// Here we can write one more condition based on requirment
    /// 1.Where Condition: 1 => This condition comes under filtering operator.
    ///                    2 => This is used to filter specific data from a data source based on a condition.
    ///                    3 => Where always expects a condition.
    ///                    4 => Condition can be written using this symbols : ==, >, >=, <, <=, ||, &&, etc..
    /// 2.OfType Condition:1 => This condition is comes under filtering operator.
    ///                    2 => This is used to filter specific data based on their type.
    ///                    3 => This is used as a generic method to filter data based on any type
    /// </summary>
    public class FilteringOperators
    {
        public void WhereMethod()
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = dataSource.Where(number => number > 5).ToList();

            var querySyntax = (from number in dataSource
                               where number > 5
                               select number).ToList();

            Console.ReadLine();
        }

        public void WhereMethodExample()
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = dataSource.Where(number => number <= 5 || number > 9).ToList();

            var querySyntax = (from number in dataSource
                               where number <= 5 || number > 9
                               select number).ToList();

            Console.ReadLine();
        }

        public void WhereMethodSimpleExample()
        {
            var dataSource = new List<string>() { "Tom", "Harry", "Adam", "Ponting", "Sachin" };

            var methodSyntax = dataSource.Where(number => number.Length > 5 || number == "Tom").ToList();

            var querySyntax = (from data in dataSource
                               where data == "Tom" || data.Length > 5
                               select data).ToList();

            Console.ReadLine();
        }

        public void WhereMethodComplexExample()
        {
            List<Employee> dataSource = EmployeeTestData.GetTechnologiesFromWhereMethod();

            var methodSyntax = dataSource.Where(employee => employee.Programming.Count > 3 || employee.Name == "Kim").ToList();

            var querySyntax = (from employee in dataSource
                               where employee.Programming.Count == 2
                               && employee.Id == 4
                               select employee).ToList();

            Console.ReadLine();
        }

        public void OfTypeMethod()
        {
            var dataSource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };

            var methodSyntax = dataSource.OfType<string>().Where(number => number.Length > 3).ToList();

            var querySyntax = (from number in dataSource
                               where number is string
                               select number).ToList();

            Console.ReadLine();
        }

        public void OfTypeMethodExample()
        {
            List<Employee> dataSource = EmployeeTestData.GetFromOfTypeMethod();

            var methodSyntax = dataSource.OfType<Employee>();

            foreach(var number in methodSyntax)
            {
                Console.WriteLine("Employee Name: {0}", number.Name);
            }

            Console.ReadLine();
        }
    }
}
