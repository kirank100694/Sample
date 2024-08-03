using System;

namespace AssmblyTypeone
{
    /// <summary>
    /// public :	There are no restrictions on accessing public members.
    /// private:	Access is limited to within the class definition. This is the default access modifier type if none is formally specified.
    /// protected : Access is limited to within the class definition and any class that inherits from the class.
    /// </summary>
    public class AssmblyTypeoneClass
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }

        private void Output()
        {
            Console.WriteLine("Output");
        }

        protected void Input()
        {
            Console.WriteLine("Input");
        }
    }
}
