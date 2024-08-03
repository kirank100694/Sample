using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.ProtectedAccessModifier
{
    public class Customer
    {
        protected int ID;
    }

    public class CorporateCustomer : Customer 
    {
        public void printID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;

            base.ID = CC.ID;
            this.ID = CC.ID;
        }
    }
}
