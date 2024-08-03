using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using Day40Concepts.StudentTestDataClass;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.SetOperationsExceptMethod
{
    /// <summary>
    /// Except method is used to return all the elements from one datasource that do not exist in second datasource.
    /// It has 2 overloaded methods.
    /// Except can be used with compareralso.
    /// </summary>
    public class ExceptMethod
    {
        public void ExceptMethodExample()
        {
            List<string> firstDatasource = new List<string>() { "A", "B", "C", "D" };

            List<string> secondDatasource = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = firstDatasource.Except(secondDatasource).ToList();

            foreach (var data in methodSyntax)
            {
                Console.WriteLine(data);
            }

            Console.ReadLine();
        }

        public void ExceptMethodSimpleExample()
        {
            double[] numbers = { 2.0, 2.1, 2.2, 2.3, 2.4, 2.5 };

            double[] number = { 2.2 };

            var methodSyntax = numbers.Except(number).ToList();

            foreach (var result in methodSyntax)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        public void ExceptMethodComplexExample()
        {
            List<Student> dataSource = StudentTestData.GetSetOperationMethods();

            var methodSyntax = dataSource.Except(dataSource, new FirstStudentComparer()).ToList();

            var quarySyntax = (from students in dataSource
                               select students).Except(dataSource, new FirstStudentComparer()).ToList();

            foreach (var studentData in methodSyntax)
            {
                Console.WriteLine(studentData);
            }

            Console.ReadLine();
        }
    }
}
