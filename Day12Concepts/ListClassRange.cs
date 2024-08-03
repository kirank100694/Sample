using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class ListClassRange
    {
        public static void DisplayCustomer()
        {
            CustomerType customer1 = new CustomerType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "Retail Customer"
            };
            CustomerType customer2 = new CustomerType()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "Retail Customer"
            };
            CustomerType customer3 = new CustomerType()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "Retail CustomerType"
            };
            CustomerType customer4 = new CustomerType()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "Corporate CustomerTypes"
            };
            CustomerType customer5 = new CustomerType()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "Corporate Customers"
            };

            List<CustomerType> listcustomers = new List<CustomerType>();
            listcustomers.Add(customer1);
            listcustomers.Add(customer2);
            listcustomers.Add(customer3);

            List<CustomerType> listCorporatecustomers = new List<CustomerType>();
            listCorporatecustomers.Add(customer4);
            listCorporatecustomers.Add(customer5);

            listcustomers.AddRange(listCorporatecustomers);
            List<CustomerType> customers = listcustomers.GetRange(0, 3);

            //listcustomers.InsertRange(3, listCorporatecustomers);
            //listcustomers.Remove(customer1);
            //listcustomers.RemoveAt(4);
            //listcustomers.RemoveAll(X => X.Type == "Corporate Customers");
            listcustomers.RemoveRange(2, 1);


            foreach (CustomerType c in listcustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", c.ID, c.Name, c.Salary, c.Type);
            }
        }
    }
}
