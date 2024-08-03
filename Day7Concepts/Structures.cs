using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.Structures
{
    /// <summary>
    /// Private Field, Public Properties and Constructors
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
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }
    }
}
