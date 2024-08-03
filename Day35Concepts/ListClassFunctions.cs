using System;
using System.Collections.Generic;
using System.Linq;
using Day35Concepts.CustomerClass;
using Day35Concepts.CustomerTestClassData;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.ListClassFunctions
{
    #region ClassFunction
    public class ClassFunction
    {
        /// <summary>
        /// 1.Contains() Function   : Check if an item exists in the list. This method returns true if the item exists, else false.
        /// 2.Exists() Function     : Check if an item exists in the list based on a condition.This method returns true if the item exists,else false.
        /// 3.Find() Function       : Searches for an element that matches the conditions defined by the specific lambda expression 
        ///                           and return the first matching item from the list
        /// 4.FindLast() Function   : Searches for an element that matches the condition defined by the specified lambda expression
        ///                           and returns the last matching item from the list
        /// 5.FindAll() Function    : Return all the items from the list that match the conditions specified by the lambda expression
        /// 6.FindIndex() Function  : Returns the index of the first item, that matches the condition specified by the lambda expression.
        /// 7.FindLastIndex() Function:Returns the index of the last item that matches the condition specified by the lambda expression.
        /// </summary>
        public void DisplayClassFunction()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomer();

            Customer customer = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500
            };

            if (listCustomers.Contains(customer))
            {
                Console.WriteLine("Customer3 object exits in the list");
            }
            else
            {
                Console.WriteLine("Customer3 object does not exits in the list");
            }
        }

        public void ExistsExample()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomer();


            if (listCustomers.Exists(cust => cust.Name.StartsWith("p")))
            {
                Console.WriteLine("Customer3 object exits in the list");
            }
            else
            {
                Console.WriteLine("Customer3 object does not exits in the list");
            }
            Customer customer = listCustomers.Find(cust => cust.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);

            Customer customer1 = listCustomers.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);

            List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 5000);

            foreach (Customer customer2 in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            int index = listCustomers.FindIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Index = " + index);

            foreach (Customer listCustomer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", listCustomer.ID, listCustomer.Name, listCustomer.Salary);
            }

            Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Customer> keyvaluepair in dictionary)
            {
                Console.WriteLine("key = " + keyvaluepair.Key);
                Customer customer3 = keyvaluepair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer1.ID, customer1.Name, customer1.Salary);
            }
        }
    }
    #endregion
}
