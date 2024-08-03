using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.AccessModifiers
{
    #region AccessModifiers
    /// <summary>
    /// Access modifiers in C# specify the scope of accessibility of a member of a class or type of the class itself. 
    /// public class is accessible to everyone without any restrictions, while an internal class may be accessible to the assembly only.
    /// </summary>
    public class Customer
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public void printId()
        {
            Customer customer = new Customer();
            customer.ID = _id;  
        }
    }

    public class ProtectedCustomer
    {
        protected int ID;
    }

    public class CorporateCustomer : ProtectedCustomer
    {
        public void printID()
        {
            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.ID = 101;

            base.ID = corporateCustomer.ID;
            this.ID = corporateCustomer.ID;
        }
    }
    #endregion
}
