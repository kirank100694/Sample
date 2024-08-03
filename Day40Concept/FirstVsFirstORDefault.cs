using System;
using System.Collections.Generic;
using System.Linq;
using Day40Concepts.StudentClass;
using System.Text;
using System.Threading.Tasks;

namespace Day40Concepts.ElementOperatorsFirstVsFirstORDefault
{
    /// <summary>
    /// FirstVSFirstOrDefault method both are used (Independently) to return first element from a datasource.
    /// If the element is not available at first index,
    ///     1.First will throw an exception
    ///     2.But FirstOrDefault will return default value of datasource element.
    /// </summary>
    public class FirstVSFirstOrDefaultMethod
    {
        public void FirstVSFirstOrDefaultMethodExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.First(number => number > 5);

            Console.ReadLine();
        }

        public void FirstVSFirstOrDefaultMethodComplexExample()
        {
            var users = new List<User>()
            {
                new User(){Id = 1, UserName = "Admin", Password = "Admin"},
                new User(){Id = 2, UserName = "UserA", Password = "UserA"},
                new User(){Id = 3, UserName = "UserB", Password = "UserB"},
                new User(){Id = 4, UserName = "UserC", Password = "UserC"}
            };

            var methodSyntax = users.FirstOrDefault(user => user.UserName == "Admin" && user.Password == "Admin");

            var mixedSyntax = (from user in users
                               select user).FirstOrDefault(user => user.UserName == "UserB" && user.Password == "UserB");

            Console.ReadLine();
        }
    }
}
