using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.WhyProperties
{
    /// <summary>
    /// Marking a class fields public and exposing to the external world is bad,
    /// as you will not have control over what gets assigned and returned.
    /// Problems with public field: 
    ///     1.Id should always be non negative number.
    ///     2.Name cannot be set to null.
    ///     3.If student name is missing "no Name" should be returned.
    ///     4.Pass marks should be read only.
    /// </summary>
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
