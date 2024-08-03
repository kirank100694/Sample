using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public List<Subject> Subject { get; set; }
    }

    class FirstStudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
        }

        public int GetHashCode(Student obj)
        {
            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (object.ReferenceEquals(x, y)) 
            {
                return true; 
            }

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Student obj)
        {
            if(object.ReferenceEquals(obj,null))
            {
                return 0;
            }

            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHashCode ^ nameHashCode;

        }
    }
}
