using System;
using System.Collections.Generic;
using Day35Concepts.CustomerClass;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day35Concepts.CustomerTestClassData;

namespace Day35Concepts.ListOfComplexType
{
    /// <summary>
    /// To sort a list complex types without using LINQ, the complex type has to implement IComparable interface
    /// and provide implementation for CompareTo() method. This CompareTo() method returns an integer, 
    /// and the meaning of the return value is shown below.RETURN VALUE is
    /// 1.Greater than zero: The current instance is greater than the object being compared with.
    /// 2.Less than zero: The current instance is less than the object being compared with.
    /// 3.Is zero: The current instance is equal to the object being compared with.
    /// Alternatively you can also invoke CompareTo() method. Salary property of the customer object is int.
    /// CompareTo() method is already implemented on integer type, So we can invoke this method and return it's value.
    /// </summary>
    public class ComplexType
    {
        public void ComplexTypeExample()
        {
            List<Customer> listCustomers = CustomerTestData.GetCustomer();

            Console.WriteLine("Before Sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }
            listCustomers.Sort();
            listCustomers.Reverse();

            Console.WriteLine("After Sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            SortByName sortByName = new SortByName();

            listCustomers.Sort(sortByName);

            Console.WriteLine("Sorting by Name");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
