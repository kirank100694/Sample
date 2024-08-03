using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18Concepts
{
    public class SortingOperators
    {
        public static void ExampleOfOrderByMethod()
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var querySyntax = (from num in dataSourceInt
                               where num >10
                               orderby num
                               select num).ToList();

            var methodSyntax = dataSourceInt.Where(num => num >10).OrderBy(num => num).ToList();

            foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void AnoyherExampleOfOrderByMethod()
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var dataSourceString = new List<string>() {
                "Smith",
                "Anderson",
                "wright",
                "Mitchell",
                "Thomas",
                "Allen",
                "Evans",
                "Collins",
            };

            var querySyntax = (from name in dataSourceString
                               where name.Length > 6
                               orderby name
                               select name).ToList();

            var methodSyntax = dataSourceString.Where(name => name.Length > 6).OrderBy(name => name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void FinalExampleOfOrderByMethod()
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){
                    Id = 3,
                    Email = "Smith@gmail.com",
                    Name = "Smith"
                },
                new Employee(){
                    Id = 2,
                    Email = "Thomas@gmail.com",
                    Name = "Thomas"
                },
                new Employee(){
                    Id = 1,
                    Email = "Allen@gmail.com",
                    Name = "Allen"
                },
                new Employee(){
                    Id = 4,
                    Email = "Anderson@gmail.com",
                    Name = "Anderson"
                }
            };

            var quarySyntax = (from emp in dataSource
                               where emp.Id > 2
                               orderby emp.Id
                               select emp).ToList();

            var methodSyntax = dataSource.Where(emp => emp.Id > 2).OrderBy(emp => emp.Name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void ExampleOfOrderByDescendingOperator()
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var querySyntax = (from num in dataSourceInt
                               where num > 20
                               orderby num descending
                               select num).ToList();

            var methodSyntax = dataSourceInt.Where(num => num > 10).OrderByDescending(num => num).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void AnoyherExampleOfOrderByDescendingOperator()
        {
            var dataSourceString = new List<string>() {
                "Smith",
                "Anderson",
                "wright",
                "Mitchell",
                "Thomas",
                "Allen",
                "Evans",
                "Collins",
            };

            var ms = dataSourceString.OrderByDescending(name => name).ToList();


            var qs = from name in dataSourceString
                     orderby name descending
                     select name;

            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void FinalExampleOfOrderByDescendingOperator()
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){
                    Id = 3,
                    Email = "Smith@gmail.com",
                    Name = "Smith"
                },
                new Employee(){
                    Id = 2,
                    Email = "Thomas@gmail.com",
                    Name = "Thomas"
                },
                new Employee(){
                    Id = 1,
                    Email = "Allen@gmail.com",
                    Name = "Allen"
                },
                new Employee(){
                    Id = 4,
                    Email = "Anderson@gmail.com",
                    Name = "Anderson"
                }
            };

            var ms = dataSource.OrderByDescending(emp => emp.Id).ToList();

            var qs = (from emp in dataSource
                      orderby emp.Id descending
                      select emp).ToList();

            foreach (var item in qs)
            {
                Console.WriteLine($"Order = {item.Id}, name = {item.Name}, Email = {item.Email}");
            }

            Console.ReadLine();
        }

        public static void ExampleOfReverseOperator()
        {
            int[] rollnumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var mq = rollnumbers.Reverse().ToList();

            var qs = (from number in rollnumbers
                      select number).Reverse();

            foreach (var item in mq)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void AnotherExampleOfReverseOperator()
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
