using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.QuantifierOperationContains
{
    /// <summary>
    /// It is used to check whether a sequence(Datasource) contains a specified element.
    /// For a source of objects, contains only check referance to work with value we need to do some extra things.
    /// It returns boolean value.
    /// </summary>
    public class ContainsMethod
    {
        public void ContainsMethodExample()
        {
            List<string> students = new List<string>() { "Kim", "Jacob", "Simon", "John" };

            var methodSyntax = students.AsEnumerable().Contains("Kim");

            var quarySyntax = (from Student in students
                               select Student).Contains("Nitish");

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void ContainsMethodExample2() 
        {
            List<Student> studentList = new List<Student>() {
             new Student() { Id = 1, Name = "John", Age = 18 } ,
             new Student() { Id = 2, Name = "Steve",  Age = 15 } ,
             new Student() { Id = 3, Name = "Bill",  Age = 25 } ,
             new Student() { Id = 4, Name = "Ram" , Age = 20 } ,
             new Student() { Id = 5, Name = "Ron" , Age = 19 }
            };

            var comparer = new StudentComparer();

            var methodSyntax = studentList.Contains(new Student() { Id = 3, Name = "Bill", Age = 25 }, comparer);

            var querySyntax = (from student in studentList
                               select student).Contains(new Student() { Id = 3, Name = "Bill", Age = 25 }, comparer);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void ContainsMethodComplexExample()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Kim"},
                new Student(){ Id = 2, Name = "John"},
            };

            var comparer = new StudentComparer();

            var methodSyntax = students.Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

            var querySyntax = (from student in students
                               select student).Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
