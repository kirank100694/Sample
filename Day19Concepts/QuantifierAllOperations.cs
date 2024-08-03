using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    class QuantifierAllOperations
    {
        public static void ExampleOfAllOperator()
        {
            Student[] students = { new Student { Name = "Kim", Marks = 90 },
                                   new Student {Name = "John", Marks = 80 },
                                   new Student {Name = "Lee", Marks = 75 } 
            };

            var methodsyntax = students.All(students => students.Marks > 70);

            var querysyntax = (from student in students
                               select student).All(x => x.Marks > 70);

            Console.ReadLine();
        }

        public static void AnotherExampleOfAllOperator()
        {
            Student[] students ={
                new Student{ Name = "Kim", Marks = 90,
                    Subject = new List<Subject>(){
                              new Subject(){ subjectName = "Math", subjectMarks = 75},
                              new Subject(){ subjectName = "English", subjectMarks = 80},
                              new Subject(){ subjectName = "Art", subjectMarks = 86},
                              new Subject(){ subjectName = "History", subjectMarks = 91},
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

            var methodSyntax = students.Where(std => std.Subject.All(x => x.subjectMarks > 70)).Select(std => std).ToList();

            var queryStntax = (from std in students
                               where std.Subject.All(x => x.subjectMarks > 70)
                               select std).ToList();

            Console.ReadLine();
        }
    }
}
