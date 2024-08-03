using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.TypesAndTypeMumbers
{
    public class Customer
    {
        #region Field
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        #endregion
    }
}
