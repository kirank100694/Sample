using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.WhyProperties
{
    public class Student
    {
        public int ID;
        public string Name;
        public int PassMark = 35;
    }

    /// <summary>
    /// Getter And Setter Methords
    /// </summary>
    public class Students
    {
        private int _id;
        private string _Name;
        private int _passMarks = 35;

        public int GetpassMark()
        {
            return this._passMarks;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name Can not be null or empty");
            }
            this._Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;  //We Use Ternary Operator Here

            //if (string.IsNullOrEmpty(this._Name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._Name;
            //}

        }

        public void setId(int id)
        {
            if (id <= 0)
                throw new Exception("Student id should be greater then zero");
            this._id = id;
        }
        public int GetId()
        {
            return _id;
        }
    }
}
