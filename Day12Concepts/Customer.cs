using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }

    public class CustomerType : Customer
    {
        public string Type { get; set; }
    }

    public class CustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class CustomerSalary : IComparable<Customer>
    {
        public int Salary { get; set; }
        public int CompareTo(Customer other)
        {

            return this.Salary.CompareTo(other.Salary);
        }
    }

}
