using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.CustomerClass
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
    }

    public class CustomerType : Customer
    {
        public string Type { get; set; }
    }

    public class CustomerComparer : IComparable<Customer>
    {
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {

            return this.Salary.CompareTo(other.Salary);
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

    public class CountryCode
    {
        public string Code { get; }

        public CountryCode(string code)
        {
            Code = code;
        }

        public override bool Equals(object type)
        {
            if (type == null)
            {
                return false;
            }
            if (!(type is CountryCode))
            {
                return false;
            }
            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((CountryCode)type).Code);
        }
        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code);
        }
    }
    public class Ambassador
    {
        public CountryCode CountryCode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
