using System;
using System.Collections.Generic;
using Day35Concepts.CustomerClass;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35Concepts.CustomerTestClassData;

namespace Day35Concepts.ComplexTypeUsingComparisionDelegate
{
    public class ComparisionDelegate
    {
        public void ComparisionDelegateExample()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomer();

            foreach (var customer in listCustomers)
            {
                listCustomers.Add(customer);
            }

            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.ID);
            }

            listCustomers.Sort(customerComparer);
            listCustomers.Sort(delegate (Customer customer1, Customer customer2) { return customer1.ID.CompareTo(customer2.ID); });
            listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("After Sorting");

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        private int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}
