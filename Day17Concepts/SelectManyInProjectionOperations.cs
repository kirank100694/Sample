using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class SelectManyInProjectionOperations
    {
        public static void DisplaySelectManyProjectionOperations()
        {
            List<string> strList = new List<string>() { "Nitish", "Kaushik" };

            var methodResult = strList.SelectMany(x => x).ToList();

            var queryResult = (from rec in strList
                               from ch in rec
                               select ch).ToList();

            Console.ReadLine();
        }

        public static void DisplaySelectInDataSource()
        {
            var dataSource = new List<Employee>()
            {
                new Employee() {Id =  1, Name = "Tom", Email = "Tom@gmail.com", 
                    Programming = new List<string> () {"C#", "PHP", "JAVA" } },
                new Employee() {Id =  2, Name = "Kim", Email = "Kim@gmail.com", 
                    Programming = new List<string> () {"LINQ", "C#", "MVC" } },
                new Employee() {Id =  3, Name = "Harry", Email = "Harry@gmail.com", 
                    Programming = new List<string> () { "LINQ", "VB", "SQL" } }
            };

            var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            var quarySyntax = (from emp in dataSource
                               from skill in emp.Programming
                               select skill).ToList();

            foreach(var item in methodSyntax)
            {
                Console.WriteLine("Programming - " + item);
            }

            Console.ReadLine();
        }

        public static void DisplaySelectInAnotherExample() 
        {
            var dataSource = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tom", Email = "tom@gmail.com", Program =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "PHP"},
                    new Techs() { Technology = ".Net"}
                }},
                new Employee() {Id = 2, Name = "John", Email = "john@gmail.com", Program =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "VB"},
                    new Techs() { Technology = "SQL"}
                }},
                new Employee() {Id = 3, Name = "Mark", Email = "mark@gmail.com", Program =
                new List<Techs> (){
                    new Techs() { Technology = "LINQ"},
                    new Techs() { Technology = "MVC"},
                    new Techs() { Technology = "C#"}
                }},
                new Employee(){Id = 4, Name = "Kim", Email = "kim@gmail.com", Program = new List<Techs>()},
                new Employee(){Id = 5, Name = "Adam", Email = "adam@gmail.com", Program = new List<Techs>()},
            };

            var methodQuery = dataSource.SelectMany(emp => emp.Program).ToList();

            var querySyntax = (from emp in dataSource
                               from pro in emp.Program
                               select pro).ToList();

            Console.ReadLine();
        }
    }
}
