using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.Properties
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMarks = 35;

        public int passMark
        {
            get
            {
                return _passMarks;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("Name Can not be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id should be greater then zero");
                    this._id = value;
                }
            }
            get
            {
                return this._id;
            }
        }

    }

    /// <summary>
    /// Auto Implemented Properties
    /// </summary>
    public class Students
    {
        private int _id;
        private string _Name;
        private int _passMarks = 35;
        private string _City;
        private string _Email;

        public string City
        { get; set; }
        public string Email
        { get; set; }

        public int passMark
        {
            get
            {
                return _passMarks;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("Name Can not be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Student id should be greater then zero");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
    }
}
