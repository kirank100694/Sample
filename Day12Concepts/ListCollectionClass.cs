using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{

    public class ListCollectionClass
    {
        public static void DisplayCustomers()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 500
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };
            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Insert(0, customer3);

            Console.WriteLine(customers.IndexOf(customer3, 1));

            for (int i = 0; i < customers.Count; i++)
            {
                Customer C = customers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C.ID, C.Name, C.Salary);
            }

            foreach (Customer C in customers)
            {
                Console.WriteLine(C.ID);
            }
        }
    }
}
