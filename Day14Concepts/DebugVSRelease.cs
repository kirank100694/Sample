using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts
{
    
    public static class DebugVsRelease
    {
        public static void DisplayDebugVsRelease()
        {
            M1();
        }
        static void M1 ()
        {
            M2();
        }
        static void M2 ()
        {
            M3();
        }
        static void M3 ()
        {
            throw new Exception("Some error");
        }
    }
}
