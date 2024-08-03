using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }
    }
}
