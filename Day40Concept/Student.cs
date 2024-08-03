using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day40Concepts.StudentClass
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public int Age {  get; set; }
        public List<Subject> Subject { get; set; }
    }

    public class Subject
    {
        public string subjectName { get; set; }
        public int subjectMarks { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student one, Student two )
        {
            if (object.ReferenceEquals(one, two))
            {
                return true;
            }

            if (object.ReferenceEquals(one, null) || object.ReferenceEquals(two, null))
            {
                return false;
            }

            return one.Id == two.Id && one.Name == two.Name;
        }

        public int GetHashCode(Student studentObject)
        {
            if (object.ReferenceEquals(studentObject, null))
            {
                return 0;
            }

            int idHashCode = studentObject.Id.GetHashCode();
            int nameHashCode = studentObject.Name == null ? 0 : studentObject.Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }

    public class FirstStudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student one, Student two)
        {
            return one.Id.Equals(two.Id) && one.Name.Equals(two.Name);
        }

        public int GetHashCode(Student studentObject)
        {
            int idHashCode = studentObject.Id.GetHashCode();
            int nameHashCode = studentObject.Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
