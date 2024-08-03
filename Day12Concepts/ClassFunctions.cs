using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public static class ClassFunction
    {
        /// <summary>
        /// 1.Contains() Function
        /// 2.Exists() Function
        /// 3.Find() Function
        /// 4.FindLast() Function
        /// 5.FindAll() Function
        /// 6.FindIndex() Function
        /// 7.FindLastIndex() Function
        /// </summary>
        public static void DisplayCustomer()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 5500
            };
            List<Customer> Listcustomers = new List<Customer>(2);
            Listcustomers.Add(customer1);
            Listcustomers.Add(customer2);
            Listcustomers.Add(customer3);

            if (Listcustomers.Contains(customer3))
            {
                Console.WriteLine("Customer3 object exits in the list");
            }
            else
            {
                Console.WriteLine("Customer3 object does not exits in the list");
            }

            if (Listcustomers.Exists(cust => cust.Name.StartsWith("p")))
            {
                Console.WriteLine("Customer3 object exits in the list");
            }
            else
            {
                Console.WriteLine("Customer3 object does not exits in the list");
            }
            Customer C = Listcustomers.Find(cust => cust.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C.ID, C.Name, C.Salary);

            Customer C1 = Listcustomers.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C.ID, C.Name, C.Salary);

            List<Customer> customers = Listcustomers.FindAll(cust => cust.Salary > 5000);

            foreach (Customer C2 in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C.ID, C.Name, C.Salary);
            }

            int index = Listcustomers.FindIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Index = " + index);

            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;

            List<Customer> listcustomers = customerArray.ToList();
            foreach (Customer c in listcustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            List<Customer> listcustomers1 = new List<Customer>();
            listcustomers.Add(customer1);
            listcustomers.Add(customer2);
            listcustomers.Add(customer3);

            Dictionary<int, Customer> dictionary = listcustomers1.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("key = " + kvp.Key);
                Customer C3 = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C1.ID, C1.Name, C1.Salary);
            }
        }
    }

}
