using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    class DistinctMethodInSetOperators
    {
        public static void SimpleExampleOfDistinctOperator()
        {
            List<int> numbers = new List<int>() {1, 2, 3, 1, 2, 3, 4, 3, 5, 5, 5 }; 

            var methodsyntax = numbers .Distinct().ToList();

            var querysyntax = (from num in numbers
                     select num).ToString().ToList();

            Console.ReadLine();
        }

        public static void ComplexAnotherExampleOfDistinctOperator()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 2, Name = "Kim"},
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 4, Name = "Mark"},
            };
            
            var methodsyntax = students.Distinct(new FirstStudentComparer()).ToList();

            Console.ReadLine();
        }
    }
}
