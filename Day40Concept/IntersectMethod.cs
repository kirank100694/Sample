using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using Day40Concepts.StudentTestDataClass;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.SetOperationsIntersectMethod
{
    /// <summary>
    /// Intersect method is used to find the common elements in both datasource.
    /// It has 2 overload methods
    /// Intersect can be used as with comparer also.
    /// </summary>
    public class IntersectMethod
    {
        public void IntersectMethodExample()
        {
            List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            var methodsyntax = datasource1.Intersect(datasource2).ToList();

            var mixedStntax = (from str in datasource2
                               select str).Intersect(datasource1).ToList();

            Console.ReadLine();
        }

        public void IntersectMethodSimpleExample()
        {
            int[] numbers = { 44, 26, 92, 30, 71, 38 };
            int[] commonNumbers = { 39, 59, 83, 47, 26, 4, 30 };

            var methodSyntax = numbers.Intersect(commonNumbers);

            foreach (int number in methodSyntax)
            {
                Console.WriteLine(number);

            }
            Console.ReadLine();
        }

        public void IntersectMethodComplexExample()
        {
            List<Student> dataSource = StudentTestData.GetSetOperationMethods();

            var methodSyntax = dataSource.Intersect(dataSource, new FirstStudentComparer()).ToList();

            foreach (var result in methodSyntax)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
