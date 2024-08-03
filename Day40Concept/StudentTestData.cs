using System;
using System.Collections.Generic;
using Day40Concepts.StudentClass;
using Day40Concepts.PartitioningOperatorsTakeMethod;
using Day40Concepts.SetOperationsExceptMethod;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.StudentTestDataClass
{
    public class StudentTestData
    {
        public static List<Student> GetSetOperationMethods()
        {
            List<Student> studentsList = new List<Student>()
                {
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 2, Name = "Kim"},
                new Student() { Id = 3, Name = "John"},
                new Student() { Id = 4, Name = "Mark"},
                new Student() { Id = 1, Name = "John"},
                new Student() { Id = 2, Name = "Kim"},
                new Student() { Id = 5, Name = "John"},
                new Student() { Id = 6, Name = "Mark"},
                };

            return studentsList;
        }

        public static List<User> GetDataTakeMethod()
        {
            List<User> employeeList = new List<User>()
                {
                new User { Id = 1, Name = "Preety", Salary = 10000, Gender = "Female"},
                new User { Id = 2, Name = "Priyanka", Salary =20000, Gender = "Female"},
                new User { Id = 3, Name = "Anurag", Salary = 35000, Gender = "Male"},
                new User { Id = 4, Name = "Pranaya", Salary = 45000, Gender = "Male"},
                new User { Id = 5, Name = "Sambit", Salary = 15000, Gender = "Male"},
                new User { Id = 6, Name = "Hina", Salary = 25000, Gender = "Female"},
                new User { Id = 7, Name = "Santosh", Salary = 39000, Gender = "Male"},
                new User { Id = 8, Name = "Sukanta", Salary = 55000, Gender = "Male"}
                };
            return employeeList;
        }
    }
}
