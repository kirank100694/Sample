using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts
{
    public class FilteringOperators
    {
        public void WhereMethod()
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = (from number in dataSource
                               where number > 5
                               select number).ToList();

            var methodSyntax = dataSource.Where(num => num > 5).ToList();

            Console.ReadLine();
        }

        public static void ExampleOfWhereMethod()
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = (from number in dataSource
                               where number <= 5 || number > 9
                               select number).ToList();

            var methodSyntax = dataSource.Where(num => num <= 5 || num > 9).ToList();

            Console.ReadLine();
        }

        public static void AnotherExampleOfWhereMethod()
        {
            var dataSource = new List<string>() { "Tom", "Harry", "Adam", "Ponting", "Sachin"};

            var querySyntax = (from str in dataSource
                               where str == "Tom" || str.Length > 5
                               select str).ToList();

            var methodSyntax = dataSource.Where(str => str.Length > 5 || str == "Tom").ToList();

            Console.ReadLine();
        }

        public static void FinalExampleOfWhereMethod()
        {
            var dataSource = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tom", Email = "tom@gmail.com", Programming =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "PHP"},
                    new Techs() { Technology = ".Net"},
                    new Techs() { Technology = "MVC"},
                    new Techs() { Technology = "SQL"},
                }},
                new Employee() {Id = 2, Name = "John", Email = "john@gmail.com", Programming =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "VB"},
                    new Techs() { Technology = "SQL"}
                }},
                new Employee() {Id = 3, Name = "Mark", Email = "mark@gmail.com", Programming =
                new List<Techs> (){
                    new Techs() { Technology = "LINQ"},
                    new Techs() { Technology = "MVC"},
                }},
                new Employee(){Id = 4, Name = "Kim", Email = "kim@gmail.com", Programming = new List<Techs>()},
                new Employee(){Id = 5, Name = "Adam", Email = "adam@gmail.com", Programming = new List<Techs>()},
            };

            var querySyntax = (from employee in dataSource
                               where employee.Programming.Count == 2
                               && employee.Id == 4
                               select employee).ToList();

            var methodSyntax = dataSource.Where(employee => employee.Programming.Count > 3 || employee.Name == "Kim").ToList();

            Console.ReadLine();
        }

        public static void ExampleOfTypeMethod()
        {
            var dataSource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5};

            var methodSyntax = dataSource.OfType<string>().Where(x => x.Length > 3).ToList();

            var querySyntax = (from x in dataSource
                               where x is string   
                               select x).ToList();

            Console.ReadLine();
        }
    }
}
