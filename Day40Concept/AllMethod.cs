using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.QuantifierOperationAll
{
    /// <summary>
    /// All Method is used to check whether all the elements of a data source satisfy a specified condition.
    /// It returns boolean value.
    /// </summary>
    public class AllMethod
    {
        public void AllMethodExample()
        {
            Student[] students = { new Student { Name = "Kim", Marks = 90 },
                                   new Student {Name = "John", Marks = 80 },
                                   new Student {Name = "Lee", Marks = 75 }
            };

            var methodSyntax = students.All(students => students.Marks > 70);

            var querySyntax = (from student in students
                               select student).All(x => x.Marks > 70);

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void AllMethodExample2()
        {
            List<Student> studentList = new List<Student>() {
                                        new Student() { Id = 1, Name = "Sai", Age = 18 } ,
                                        new Student() { Id = 2, Name = "Siva",  Age = 15 } ,
                                        new Student() { Id = 3, Name = "Sharath",  Age = 25 } ,
                                        new Student() { Id = 4, Name = "Singham" , Age = 20 } ,
                                        new Student() { Id = 5, Name = "Simha" , Age = 19 }
            };

            var methodSyntax = studentList.All(student => student.Age > 12 && student.Age < 20);
            
            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void AllmethodComplexExample()
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
                              new Subject() { subjectName = "History", subjectMarks = 62},
                              }},
                new Student{ Name = "Lee", Marks = 75,
                    Subject = new List<Subject>(){
                              new Subject() { subjectName = "Math", subjectMarks = 75},
                              new Subject() { subjectName = "English", subjectMarks = 80},
                              new Subject() { subjectName = "Art", subjectMarks = 60},
                              new Subject() { subjectName = "History", subjectMarks = 91},
                              }}};

            var methodSyntax = students.Where(student => student.Subject.All(subject => subject.subjectMarks > 70)).Select(student => student).ToList();

            var queryStntax = (from student in students
                               where student.Subject.All(subject => subject.subjectMarks > 70)
                               select student).ToList();

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
