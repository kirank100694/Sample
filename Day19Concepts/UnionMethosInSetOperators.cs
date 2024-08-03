using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class UnionMethosInSetOperators
    {
        public static void SampleExampleOfUnionMethod()
        {
            List<string> datasource1 = new List<string>() { "A", "A", "B", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            var methodsyntax = datasource1.Union(datasource2).ToList();

            Console.ReadLine();
        }

        public static void ComplexExampleOfUnionMethod()
        {
            List<Student> students1 = new List<Student>()
            {
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 2, Name = "Kim"},
                new Student() { Id = 3, Name = "John"},
                new Student() { Id = 4, Name = "Mark"},
            };
            List<Student> students2 = new List<Student>()
            {
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 2, Name = "Kim"},
                new Student() { Id = 5, Name = "John"},
                new Student() { Id = 6, Name = "Mark"},
            };

            var methodSyntax = students1.Union(students2, new FirstStudentComparer()).ToList();

            //var methodSyntax = students1.Select(x => new { x.Id, x.Name }).Union(students2.Select(x => new { x.Id, x.Name })).ToList();

            Console.ReadLine();
        }
    }
}
