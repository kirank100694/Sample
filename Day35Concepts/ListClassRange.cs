using System;
using System.Collections.Generic;
using Day35Concepts.CustomerClass;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35Concepts.CustomerTestClassData;

namespace Day35Concepts.ListClassRange
{
    /// <summary>
    ///AddRange(): Add() method allows you to add one item at a time to the end of the list,
    ///            Where as AddRange() allows you to add another list of items to the end of the list.
    ///GetRange(): Using an item index we can retrieve only one item at a time from the list, if you want to get a list of items from list,
    ///            Then use GetRange() function. This function expects 2 parameters, ie.. the start index in the list and the number of elements to return.
    ///InsertRange(): Insert() method allows you to insert a single item into the list at a specified index, where as 
    ///               InsertRange() allows you to insert another list of items to your list at the specified index.
    ///RemoveRange(): Remove() function removes only the first matching item from the list. 
    ///               RemoveAt() function removes the item at the specified index in the list.
    ///               RemoveAll() function removes all the items that matches the specified condition.
    ///RemoveRange() method removes a range of elements from the list. This function expects 2 parameters.
    ///ie.. the start index in the list and the number of elements to remove.If you want to remove all the element from the list without
    ///specifying any condition, then we use Clear() function
    /// </summary>
    public class ClassRange
    {
        public void DisplayCustomer()
        {
            List<CustomerType> listCustomers = CustomerTestData.GetCustomerTypes();
            List<CustomerType> listCorporatecustomers = CustomerTestData.GetCustomerTypes();


            listCustomers.AddRange(listCorporatecustomers);
            List<CustomerType> customers = listCustomers.GetRange(0, 3);

            listCustomers.InsertRange(3, listCorporatecustomers);

            CustomerType customer1 = new CustomerType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "Retail Customer"
            };

            listCustomers.Remove(customer1);


            listCustomers.RemoveAt(4);

            listCustomers.RemoveAll(X => X.Type == "Corporate Customers");

            listCustomers.RemoveRange(2, 1);

            foreach (CustomerType list in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", list.ID, list.Name, list.Salary, list.Type);
            }
        }
    }
}
