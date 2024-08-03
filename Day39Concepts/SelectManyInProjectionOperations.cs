using Day39Concepts.EmployeeClass;
using Day39Concepts.EmployeeTestDataClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day39Concepts.SelectManyInProjectionOperations
{
    public class SelectManyInMethod
    {
        public void DisplaySelectManyProjectionOperations()
        {
            List<string> list = new List<string>() { "Nitish", "Kaushik", "Saiteja" };

            var methodSyntax = list.SelectMany(character => character).ToList();

            var querySyntax = (from record in list
                               from item in record
                               select item).ToList();

            foreach( var method in methodSyntax)
            {
                Console.WriteLine(method);
            }

            Console.ReadLine();
        }

        public void DisplaySelectManyDataSource()
        {
            List<Employee> dataSource = EmployeeTestData.GetEmployeeList();

            var methodSyntax = dataSource.SelectMany(employee => employee.Programming).ToList();

            var quarySyntax = (from employee in dataSource
                               from skill in employee.Programming
                               select skill).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine("Programming - " + item);
            }

            Console.ReadLine();
        }

        public void DisplaySelectManyInExample()
        {
            List<Employee> dataSource = EmployeeTestData.GetTechnologies();


            var methodSyntax = dataSource.SelectMany(employee => employee.Programmings).ToList();

            var querySyntax = (from employee in dataSource
                               from program in employee.Programmings
                               select program).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
