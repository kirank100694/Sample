using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35Concepts.CustomerClass;
using Day35Concepts.ComplexTypeUsingComparisionDelegate;

namespace Day35Concepts.CustomerTestClassData
{
    public class CustomerTestData
    {
        public static List<Customer> GetCustomer()
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
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            return listCustomers;
        }

        public static List<CustomerType> GetCustomerTypes()
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
                Type = "Retail Customer"
            };
            CustomerType customer4 = new CustomerType()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "Corporate Customers"
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

            return listcustomers;
        }

        public static Dictionary<CountryCode, Ambassador> GetDictonaryValue()
        {
            var ambassadors = new Dictionary<CountryCode, Ambassador>();

            Ambassador england = new Ambassador
            {
                CountryCode = new CountryCode("eng"),
                Name = "John",
                Age = 25
            };
            Ambassador australia = new Ambassador
            {
                CountryCode = new CountryCode("aus"),
                Name = "Martin",
                Age = 49
            };
            Ambassador india = new Ambassador
            {
                CountryCode = new CountryCode("ind"),
                Name = "Kiran",
                Age = 32
            };

            ambassadors.Add(england.CountryCode, england);
            ambassadors.Add(australia.CountryCode, australia);
            ambassadors.Add(india.CountryCode, india);

            return ambassadors;
        }
    }
}
