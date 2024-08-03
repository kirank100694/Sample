using System;
using Assmblyone;

namespace AssmblyTwo
{
    public class AssmblyTwoClass : AssmblyoneClassI
    {
        public void Print()
        {
            AssmblyoneClassI A1  = new AssmblyoneClassI();
            base.ID = 101;

            AssmblyTwoClass A2 = new AssmblyTwoClass();
            A2.ID = 102;

            AssmblyoneClassI A3 = new AssmblyoneClassI();
            //A3.Id = 111;
        }
    }
}
