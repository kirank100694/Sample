using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.EnumsConcepts
{
    /// <summary>
    /// Default underlying type is int and the value starts at Zero.
    /// Gender Enum underlying type is now short and the value start at One.
    /// Enum values need not be in sequential order any valid underlying type value is allowed.
    /// This Enum will not complie, because the maximum value alloewd for data type is 32767.
    /// </summary>
    public enum Gender : short
    {
        UnKnown = 1,
        Male = 2,
        Female = 3
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3,
    }
}
