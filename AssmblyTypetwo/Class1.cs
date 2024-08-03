using System;
using AssmblyTypeone;

namespace AssmblyTypeTwo
{
    public class AssmblyTypeTwoClass
    {
        public void Test()
        {
            AssmblyTypeoneClass instance = new AssmblyTypeoneClass();
            instance.Print();

            AssmblyTypeoneClass output = new AssmblyTypeoneClass();
            //output.Output();

            AssmblyTypeoneClass input = new AssmblyTypeoneClass();
            //input.Input();
        }
    }
}
