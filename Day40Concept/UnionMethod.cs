using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;
using Day40Concepts.StudentTestDataClass;

namespace Day40Concepts.SetOperationsUnionMethod
{
    public class UnionMethod
    {
        /// <summary>
        /// Union operator is used to combine multible datasource.
        /// It is removes all the duplicate elements.
        /// It has 2 overloaded methods.
        /// Union can be used with comparer also.
        /// </summary>
        public void UnionMethodExample()
        {
            List<string> firstDatasource = new List<string>() { "A", "A", "B", "C", "D" };
            List<string> secondDatasource = new List<string>() { "C", "D", "E", "F" };

            var methodsyntax = firstDatasource.Union(secondDatasource).ToList();

            foreach (var dataSource in methodsyntax)
            {
                Console.WriteLine(dataSource);
            }

            Console.ReadLine();
        }

        public void UnionMethodSimpleExample()
        {
            int[] numbers = { 5, 3, 9, 7, 5, 9, 3, 7 };
            int[] commonNumbers = { 8, 3, 6, 4, 4, 9, 1, 0 };

            var methodSyntax = numbers.Union(commonNumbers);

            foreach (var number in methodSyntax)
            {
                Console.Write(number);
            }

            Console.ReadLine();
        }

        public void UnionMethodComplexExample()
        {
            List<Student> dataSource = StudentTestData.GetSetOperationMethods();

            var methodSyntax = dataSource.Union(dataSource, new FirstStudentComparer()).ToList();

            var methodSyntax1 = dataSource.Select(student => new 
                                { student.Id, student.Name }).Union(dataSource.Select(student => new { student.Id, student.Name })).ToList();

            foreach(var result in methodSyntax)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
