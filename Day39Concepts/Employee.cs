using System.Collections.Generic;

namespace Day39Concepts.EmployeeClass
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary {  get; set; }
        public List<string> Programming { get; set; }
        public List<Techs> Programmings { get; set; }
    }

    public class Techs
    {
        public string Technology { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string StEmail { get; set; }
        public string FullName { get; set; }
    }

    public class SoftwareEmployees
    {
        public string employeeName { get; set; }
        public int employeeSalary { get; set; }
    }
}
