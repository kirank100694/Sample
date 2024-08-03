using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Structures
{
    /// <summary>
    /// In C#, structures (structs) are value types that can contain constructors, 
    /// private fields, methods, public properties and methods . 
    /// They are typically used for small data structures that do not require inheritance or other features of classes.
    /// </summary>
    public struct Customer
    {

        private int _id;
        private string _name;

        public string Name
        {
            get { return this._name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public Customer(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", _id, _name);
        }
    }

    public struct Employee
    {
        public int id;

        public void getId(int id)
        {
            Console.WriteLine("Employee Id: " + id);
        }
    }
}
