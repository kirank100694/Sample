using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.EnumsConcepts
{
    /// <summary>
    /// Default underlying type is int and the value starts at Zero.
    /// Gender Enum underlying type is now short and the value start at One.
    /// Enum values need not be in sequential order any valid underlying type value is allowed.
    /// This Enum will not complie, because the maximum value allowed for data type is 32767.
    /// Enums are value types.
    /// Enum class static Getvalues() and GrtNames() methods which can be used to list enum undelyning type values and names
    /// </summary>
    public class EnumConcepts
    {
        /// <summary>
        /// We cannot convert implicitly, Explicitconversion is required.
        /// </summary>
        public void EnumsConceptExample()
        {
            //Concept.Gender gender = (Concept.Gender)3;
            //int number = (int)Concept.Gender.UnKnown;

            //Gender gender1 = (Gender)Concept.Season.Winter;

            //short[] value1 = (short[])Enum.GetValues(typeof(Gender));

            int[] values = (int[])Enum.GetValues(typeof(Gender));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Gender));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    public enum Gender : short
    {
        UnKnown = 1,
        Male = 5,
        Female = 7
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3,
    }
}
