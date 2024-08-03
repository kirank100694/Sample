using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Properties
{
    /// <summary>
    /// In C#, properties provide a flexible mechanism to read, write, or compute the value of a private field. 
    /// </summary>
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
                }
                this._id = value;
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

    public class Employee
    {
        public string employeeName = "";
        public int employeeAge = 28;

        public string name
        {
            get { return employeeName; }
            set {  employeeName = value; }
        }

        public int age
        {
            get { return employeeAge; }
            set { employeeAge = value; }
        }

        public override string ToString()
        {
            return ("name = " + name + ",Age =" + age);
        }
    }

    public class Property
    {
        private int personeAge = 0;

        public Property(int value)
        {
            personeAge = value;
        }

        public int age
        {
            get { return personeAge; }
        } 
    }

    public class Counter
    {
        private static int number = 0;

        public Counter()
        {
            number++;
        }

        public static int objects
        {
            get { return number; }
            set {  number = value; }
        }
    }
}
