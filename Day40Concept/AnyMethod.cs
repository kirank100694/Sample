using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.QuantifierOperationAny
{
    /// <summary>
    /// It is used to check whether at least one element of a datasource satisfy a specific condition.
    /// Any is also used to check if a collection contains some data or not.
    /// It returns boolean value.
    /// </summary>
    public class AnyMethod
    {
        public void AnyMethodExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            var methodSyntax = numbers.Any();

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void AnyMethodSimpleExample()
        {
            Student[] students = {new Student {Name= "Kim", Marks = 95 },
                                  new Student {Name = "John", Marks = 80},
                                  new Student {Name = "Lee", Marks = 75}
            };

            var methodSyntax = students.Any(student => student.Marks > 96);

            var querySyntax = (from student in students
                               select student).Any(student => student.Marks > 90);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void AnyMethodSimpleExample1()
        {
            List<Student> studentList = new List<Student>() {
                                        new Student() { Id = 1, Name = "Sai", Age = 18 } ,
                                        new Student() { Id = 2, Name = "Siva",  Age = 15 } ,
                                        new Student() { Id = 3, Name = "Sharath",  Age = 25 } ,
                                        new Student() { Id = 4, Name = "Singham" , Age = 20 } ,
                                        new Student() { Id = 5, Name = "Simha" , Age = 19 }
            };

            var methodSyntax = studentList.Any(student => student.Age > 12 && student.Age < 20);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void AnyMethodComplexExample()
        {
            Student[] students ={
                new Student{ Name = "Kim", Marks = 90,
                    Subject = new List<Subject>(){
                              new Subject(){ subjectName = "Math", subjectMarks = 75},
                              new Subject(){ subjectName = "English", subjectMarks = 80},
                              new Subject(){ subjectName = "Art", subjectMarks = 86},
                              new Subject(){ subjectName = "History", subjectMarks = 95},
                              }},
                new Student{ Name = "John", Marks = 80,
                    Subject = new List<Subject>(){
                              new Subject() { subjectName = "Math", subjectMarks = 89},
                              new Subject() { subjectName = "English", subjectMarks = 91},
                              new Subject() { subjectName = "Art", subjectMarks = 90},
                              new Subject() { subjectName = "History", subjectMarks = 91},
                              }},
                new Student{ Name = "Lee", Marks = 75,
                    Subject = new List<Subject>(){
                              new Subject() { subjectName = "Math", subjectMarks = 75},
                              new Subject() { subjectName = "English", subjectMarks = 80},
                              new Subject() { subjectName = "Art", subjectMarks = 60},
                              new Subject() { subjectName = "History", subjectMarks = 91},
                              }}};

            var methodSyntax = students.Where(student => student.Subject.Any(student => student.subjectMarks > 91)).
                               Select(student => student.Name).ToList();

            var querySyntax = (from student in students
                               where student.Subject.Any(student => student.subjectMarks > 91)
                               select student.Name).ToList();

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
