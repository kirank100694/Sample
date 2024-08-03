using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;
using Day40Concepts.StudentTestDataClass;

namespace Day40Concepts.PartitioningOperatorsTakeMethod
{
    /// <summary>
    /// Take method is used to get 'n' number of records from a datasource.where 'n' is an integer which is passed in take method.
    /// Take method can be used in method syntax and mixed syntax.
    /// Take method will not make any change in element position.
    /// </summary>
    public class TakeMethod
    {
        public void TakeMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Take(5).Where(number => number > 3).ToArray();

            var mixedSyntax = (from number in numbers
                               where number > 3
                               select number).Take(4).ToList();

            Console.ReadLine();
        }

        public void TakeMethodComplexExample()
        {
            List<User> employees = StudentTestData.GetDataTakeMethod();

            var methodSyntax = employees.OrderByDescending(employee => employee.Salary).Take(4).ToList();

            var querySyntax = (from employee in employees
                               orderby employee.Salary descending
                               select employee).Take(4).ToList();

            Console.ReadLine();
        }
    }
}
