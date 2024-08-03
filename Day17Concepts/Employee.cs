using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public List<Techs> Program { get; set; }
    }

    public class Techs
    {
        public string Technology { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StEmail { get; set; }
        public string FullName { get; set; }
    }
}
