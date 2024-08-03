using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    internal class AnyMethodOperator
    {
        public static void ExampleofAnyMethodOperator()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            var isAvilable = numbers.Any();

            Console.ReadLine();
        }

        public static void AnotherExampleofAnyMethodOperator()
        {
            Student[] students = {new Student {Name= "Kim", Marks = 95 },
                    new Student {Name = "John", Marks = 80},
                    new Student {Name = "Lee", Marks = 75}};

            var methodsyntax = students.Any(x => x.Marks > 96);

            var querysyntax = (from std in students
                               select std).Any(x => x.Marks > 90);

            Console.ReadLine();
        }

        public static void FinalExampleofAnyMethodOperator()
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

            var methodsyntax = students.Where(std => std.Subject.Any(x => x.subjectMarks > 91)).Select(std => std.Name).ToList();

            var querysyntax = (from std in students
                      where std.Subject.Any(x => x.subjectMarks > 91)
                      select std.Name).ToList();

            Console.ReadLine();
        }
    }
}
