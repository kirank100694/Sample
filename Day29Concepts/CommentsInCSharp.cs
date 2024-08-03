using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29Concepts
{
    /// <summary>
    /// Single Line Comment : We have to mention two slashes infront of line
    /// Muliline Comment    : Begins with an open comment mark /* and ends with a closed comment mark */
    /// page Or XML Comment : Begins with an open comment three slashes(/// <summary>) and 
    ///                       Ends with a closed comment three slashes(/// </summary>)
    /// </summary>
    internal class CommentsInCSharp
    {
        #region TypesOfComments
        public void TypesOfComments()
        {
            //Single Line Comment

            //Console.WriteLine("Test1");
            //Console.WriteLine("Test2");
            //Console.WriteLine("Test3");
            //Console.WriteLine("Test4");
            //Console.WriteLine("Test5");

            //Muliline Comment

            /*Console.WriteLine("Test1");
            Console.WriteLine("Test2");
            Console.WriteLine("Test3");
            Console.WriteLine("Test4");
            Console.WriteLine("Test5"); */

            //page Or XML Comment
            /*
            ///<summary>
            ///
            ///</summary>
            */
        }
        #endregion
    }
}
