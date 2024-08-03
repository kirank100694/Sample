using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.DebugVsReleaseConcepts
{
    /// <summary>
    /// 1.Debug and Release are build modes.
    /// 2.Debug is for development release is for production/go Live.
    /// 3.In debug mode code is not optimized, In release mode code is optimized.
    /// 4.Debug symbols are not shipped to production (Debug symbols are removed).
    /// 5.Release mode is more optimized as compared to Debug mode.
    /// 6.In Release mode the Debug symboles are removed.
    /// </summary>
    public class DebugVsRelease
    {
        public static void DisplayDebugVsRelease()
        {
            M1();
        }
        static void M1()
        {
            M2();
        }
        static void M2()
        {
            M3();
        }
        static void M3()
        {
            throw new Exception("Some error");
        }
    }
}
