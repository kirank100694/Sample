using System;
using System.Collections.Generic;
using Day35Concepts.CustomerClass;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35Concepts.CustomerTestClassData;

namespace Day35Concepts.ListCollectionClassConcept
{
    /// <summary>
    /// 1.A list class can be used to create a collection of any type
    /// 2.We can create a list of integers, string and even complextypes.
    /// 3.The objects stored in the list can be accessed by index.
    /// 3.Unlike arrays, lists can grow in size automatically.
    /// 4.This class also provides methods to serch, Sort and manipulate lists.
    /// </summary>
    public class ListCollectionClass
    {
        public void DisplayCollectionClass()
        {
            List<Customer> customers = CustomerTestData.GetCustomer();

            Customer customer = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            customers.Insert(0, customer);

            Console.WriteLine(customers.IndexOf(customer, 1));

            for (int i = 0; i < customers.Count; i++)
            {
                Customer details = customers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", details.ID, details.Name, details.Salary);
            }

            foreach (Customer customerList in customers)
            {
                Console.WriteLine(customerList.ID);
            }
        }
    }
}
