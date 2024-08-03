using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Concepts.ClassIntroduction
{
    class Customer
    {
        string _FirstName;
        string _LastName;

        public Customer(string firstName, string lastName)
        {
            this._FirstName = firstName;
            this._LastName = lastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._FirstName + "" + this._LastName);
        }
        ~Customer()
        {

        }
    }

    class CustomerInfo
    {
        string _FirstName;
        string _LastName;

        public CustomerInfo()
            : this("No First Name Provided", "No Last Name Provides")
        {

        }

        public CustomerInfo(string firstName, string lastName)
        {
            this._FirstName = firstName;
            this._LastName = lastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._FirstName + "" + this._LastName);
        }
        ~CustomerInfo()
        {
            // Clean Up Code
        }
    }

}
