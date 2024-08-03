using System;
using Day39Concepts.EmployeeClass;
using Day39Concepts.EmployeeTestDataClass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.SelectMethodProjectionOperator
{
    public class SelectInMethod
    {
        public void DisplayBasicQueryInSelectMethod()
        {
            List<Employee> listEmployees = EmployeeTestData.GetEmployee();

            var basicQuerySyntax = (from employee in listEmployees
                                    select employee).ToList();

            var basicMethodSyntax = listEmployees.ToList();

            var basicPropQuerySyntax = (from employee in listEmployees
                                        select employee.Id.ToString()).ToList();

            var basicPropMethodSyntax = listEmployees.Select(employee => employee.Name).ToList();

            foreach (var item in basicMethodSyntax)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }

            Console.ReadLine();
        }

        public void DisplaySelectInQueryMethod()
        {
            List<Employee> listEmployees = EmployeeTestData.GetEmployee();

            var querySyntax = (from employee in listEmployees
                               select new Employee()
                               {
                                   Id = employee.Id,
                                   Email = employee.Email
                               }).ToList();

            var selectQuerySyntax = (from employee in listEmployees
                                     select new
                                     {
                                         CustomId = employee.Id,
                                         CustomName = employee.Name,
                                         CustomEmail = employee.Email
                                     }).ToList();

            var methodSyntax = listEmployees.Select(employee => new Student()
            {
                StudentId = employee.Id,
                FullName = employee.Name,
                StEmail = employee.Email
            }).ToList();

            var selectMethodSyntax = listEmployees.Select(employee => new
            {
                CustomId = employee.Id,
                CustomName = employee.Name,
                CustomEmail = employee.Email
            }).ToList();

            foreach (var item in selectMethodSyntax)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }

            Console.ReadLine();
        }

        public void DisplaySelectInOperator()
        {
            List<Employee> listEmployees = EmployeeTestData.GetEmployee();

            var methodSyntax = listEmployees.Select((employee, index) => new { Index = index, fullName = employee.Name }).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine($" Name = {item.fullName}");
            }

            Console.ReadLine();
        }

        public void GetCompanyEmployees()
        {
            List<SoftwareEmployees> getEmployee = EmployeeTestData.GetCompanyDetail();


            var querySyntax = from person in getEmployee
                              select new { person.employeeName, person.employeeSalary };

            foreach (var result in querySyntax)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
