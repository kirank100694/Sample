using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class InterSectMethodInSetOperators
    {
        public static void SimpleExampleOfIntersectMethod()
        {
            List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            var methodsyntax = datasource1.Intersect(datasource2).ToList();

            var mixedStntax = (from str in datasource2
                            select str).Intersect(datasource1).ToList();

            Console.ReadLine();
        }

        public static void ComplexExampleOfIntersectMethod()
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

            var methodSyntax = students1.Intersect(students2, new FirstStudentComparer()).ToList();

            Console.ReadLine();

            
        }
    }
}
