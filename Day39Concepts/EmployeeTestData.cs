using Day39Concepts.EmployeeClass;
using System.Collections.Generic;

namespace Day39Concepts.EmployeeTestDataClass
{
    public class EmployeeTestData
    {
        public static List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id=1, Name="Tom", Email="tom@gmail.com" },
                new Employee() { Id=2, Name="John", Email="john@gmail.com" },
                new Employee() { Id=3, Name="Mark", Email="mark@gmail.com" },
                new Employee() { Id=4, Name="Kim", Email="kim@gmail.com" },
                new Employee() { Id=5, Name="Adam", Email="adam@gmail.com" },
            };

            return employees;
        }

        public static List<Employee> GetEmployeeList()
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

            return dataSource;
        }

        public static List<Employee> GetTechnologies()
        {
            var dataSource = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tom", Email = "tom@gmail.com", Programmings =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "PHP"},
                    new Techs() { Technology = ".Net"}
                }},
                new Employee() {Id = 2, Name = "John", Email = "john@gmail.com", Programmings =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "VB"},
                    new Techs() { Technology = "SQL"}
                }},
                new Employee() {Id = 3, Name = "Mark", Email = "mark@gmail.com", Programmings =
                new List<Techs> (){
                    new Techs() { Technology = "LINQ"},
                    new Techs() { Technology = "MVC"},
                    new Techs() { Technology = "C#"}
                }},
                new Employee(){Id = 4, Name = "Kim", Email = "kim@gmail.com", Programmings = new List<Techs>()},
                new Employee(){Id = 5, Name = "Adam", Email = "adam@gmail.com", Programmings = new List<Techs>()},
            };

            return dataSource;
        }

        public static List<SoftwareEmployees> GetCompanyDetail()
        {
            List<SoftwareEmployees> employee = new List<SoftwareEmployees>
            {
            new SoftwareEmployees
                {
               employeeName = "Vishnu",
               employeeSalary = 20000,
                },
            new SoftwareEmployees
                {
               employeeName = "Priya",
               employeeSalary = 40000,
                },
            new SoftwareEmployees
                {
               employeeName = "Jagat",
               employeeSalary = 800000,
                },
            };
            return employee;
        }

        public static List<Employee> GetTechnologiesFromWhereMethod()
        {
            var dataSource = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Tom", Email = "tom@gmail.com", Programmings =
                new List<Techs >(){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "PHP"},
                    new Techs() { Technology = ".Net"},
                    new Techs() { Technology = "MVC"},
                    new Techs() { Technology = "SQL"},
                }},
                new Employee() {Id = 2, Name = "John", Email = "john@gmail.com", Programmings =
                new List<Techs> (){
                    new Techs() { Technology = "C#"},
                    new Techs() { Technology = "VB"},
                    new Techs() { Technology = "SQL"}
                }},
                new Employee() {Id = 3, Name = "Mark", Email = "mark@gmail.com", Programmings =
                new List<Techs> (){
                    new Techs() { Technology = "LINQ"},
                    new Techs() { Technology = "MVC"},
                }},
                new Employee(){Id = 4, Name = "Kim", Email = "kim@gmail.com", Programmings = new List<Techs>()},
                new Employee(){Id = 5, Name = "Adam", Email = "adam@gmail.com", Programmings = new List<Techs>()},
            };

            return dataSource;
        }

        public static List<Employee> GetFromOfTypeMethod()
        {
            List<Employee>  dataSource = new List<Employee>();
            dataSource.Add(new Employee() { Id = 209, Name = "Anjita" });
            dataSource.Add(new Employee() { Id = 210, Name = "Soniya" });
            dataSource.Add(new Employee() { Id = 300, Name = "Rohan" });

            return dataSource;
        }

        public static List<Employee> GetOrderByMethodExample()
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

            return dataSource;
        }

        public static List<int> GetSortingOperatorsType()
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            return dataSourceInt;
        }

        public static List<string> GetSortingOperatorsTypes()
        {
            var dataSourceString = new List<string>()
            {
                "Smith","Anderson", "wright", "Mitchell", "Thomas", "Allen", "Evans", "Collins",
            };

            return dataSourceString;
        }

        public static List<Student> GetThenByMethod()
        {
            List<Student> studentList = new List<Student>() 
            {
            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentId = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentId = 5, StudentName = "Ron" , Age = 19 },
            new Student() { StudentId = 6, StudentName = "Ram" , Age = 18 }
            };

            return studentList;
        }
    }
}
