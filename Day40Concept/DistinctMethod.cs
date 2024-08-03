using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;
using Day40Concepts.StudentTestDataClass;

namespace Day40Concepts.SetOperationsDistinctMethod
{
    /// <summary>
    /// Distinct is used to return distinct records from a datasource means removes duplicate values from datasource
    /// It has 2 overloaded methods.
    /// Distinct can be used with comparer also
    /// </summary>
    public class DistinctMethod
    {
        public void DistinctMethodExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 3, 5, 5, 5 };

            var methodSyntax = numbers.Distinct().ToList();

            var querySyntax = (from number in numbers
                               select number).ToString().ToList();

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }

        public void DistinctMethodExample2()
        {
            List<string> names = new List<string>() { "One", "Two", "Three", "Two", "Three" };

            List<int> numbers = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

            var methodSyntaxForString = names.Distinct();

            foreach (var name in methodSyntaxForString)
            {
                Console.WriteLine(name);
            }

            var methodSyntaxForInt = numbers.Distinct();

            foreach (var number in methodSyntaxForInt)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        public void DistinctMethodComplexExample()
        {
            List<Student> dataSource = StudentTestData.GetSetOperationMethods();

            var methodSyntax = dataSource.Distinct(new FirstStudentComparer()).ToList();

            Console.WriteLine(methodSyntax);

            Console.ReadLine();
        }
    }
}
