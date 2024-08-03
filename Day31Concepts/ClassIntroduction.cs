using System;

namespace Day31Concepts.ClassIntroduction
{
    /// <summary>
    /// Classes are the primary building blocks of object-oriented programming (OOP) in C#.
    /// </summary>
    class Customer
    {
        string _FirstName;
        string _LastName;

        public Customer(string firstName, string lastName)
        {
            _FirstName = firstName;
            _LastName = lastName;
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
            _FirstName = firstName;
            _LastName = lastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", _FirstName + "" + _LastName);
        }
        ~CustomerInfo()
        {
            // Clean Up Code
        }
    }
}


