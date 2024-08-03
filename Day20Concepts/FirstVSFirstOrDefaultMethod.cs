using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class FirstVSFirstOrDefaultMethod
    {
        public static void SimpleExampleOfFirstVSFirstOrDefaultMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.First(x => x > 5);

            Console.ReadLine(); 
        }

        public static void ComplexExampleOfFirstVSFirstOrDefaultMethod()
        {
            var users = new List<User>()
            {
                new User(){Id = 1, UserName = "Admin", Password = "Admin"},
                new User(){Id = 2, UserName = "UserA", Password = "UserA"},
                new User(){Id = 3, UserName = "UserB", Password = "UserB"},
                new User(){Id = 4, UserName = "UserC", Password = "UserC"}
            };

            var methodSyntax = users.FirstOrDefault(x => x.UserName == "Admin" && x.Password == "Admin");

            var mixedSyntax = (from user in users
                              select user).FirstOrDefault(x => x.UserName == "UserB" && x.Password == "UserB");

            Console.ReadLine();
        }
    }

    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
