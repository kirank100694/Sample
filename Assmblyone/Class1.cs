using System;

namespace Assmblyone
{
    /// <summary>
    /// Internal : Any where with inthe containing assembly.
    /// Protected Internal : Any where with in the containing assembly and from with in a derived class in any another assembly.
    /// </summary>
    public class AssmblyoneClassI
    {
        internal int Id = 111;
        protected internal int ID = 101; 
    }

    public class AssmblyoneClassII
    {
        public void SampleMethod()
        {
            AssmblyoneClassI A1 = new AssmblyoneClassI();
            Console.WriteLine( A1.ID );
        }

        public void Test()
        {
            AssmblyoneClassI A1 = new AssmblyoneClassI();
            Console.WriteLine(A1.Id);
        }
    }
}
