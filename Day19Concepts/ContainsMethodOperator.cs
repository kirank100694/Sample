using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class ContainsMethodOperator
    {
        public static void SimpleExampleOfContainsMethod() 
        {
            List<string> students = new List<string>() {"Kim", "Jacob", "Simon", "John" };

            var isExist = students.AsEnumerable().Contains("Kim");

            var isExistUsingQuary = (from Student in students
                                    select Student).Contains("Nitish");

            Console.ReadLine();
        }

        public static void ComplexExampleOfContainsMethod()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Kim"},
                new Student(){ Id = 2, Name = "John"},
            };

            var comparer = new StudentComparer();

            var isExist = students.Contains(new Student() { Id = 1, Name = "Kim"}, comparer);

            var querysyntax = (from std in students
                               select std).Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

            Console.ReadLine();
        }
    }
}
