using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class ListOfComplexType
    {
        public void Program()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };
            List<Customer> Listcustomers = new List<Customer>();
            Listcustomers.Add(customer1);
            Listcustomers.Add(customer2);
            Listcustomers.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in Listcustomers)
            {
                Console.WriteLine(c.Salary);
            }
            Listcustomers.Sort();
            Listcustomers.Reverse();

            Console.WriteLine("After Sorting");
            foreach (Customer c in Listcustomers)
            {
                Console.WriteLine(c.Salary);
            }

            SortByName sortByName = new SortByName();

            Listcustomers.Sort(sortByName);

            Console.WriteLine("Sorting by Name");
            foreach (Customer c in Listcustomers)
            {
                Console.WriteLine(c.Salary);
            }
        }
    }
}
