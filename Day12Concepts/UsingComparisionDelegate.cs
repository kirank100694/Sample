using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    
    public class Delegate
    {
        public static void ComparisionDelegate()
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

            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in Listcustomers)
            {
                Console.WriteLine(c.ID);
            }
            Listcustomers.Sort(customerComparer);
            Listcustomers.Sort(delegate (Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
            Listcustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("After Sorting");
            foreach (Customer c in Listcustomers)
            {
                Console.WriteLine(c.ID);
            }
        }

        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }

    }
   
}
