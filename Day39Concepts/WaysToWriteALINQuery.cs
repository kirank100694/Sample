using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day39Concepts.WaysToWriteALINQuery
{
    /// <summary>
    /// A query is a set of instructions which is applied on a data source to perform an action (CRUD) and tells the shape of output from that query.
    /// Each query is a combination of "Initialization", "Condition", "Selection".
    /// There are three ways to write a LINQ query
    /// 1.Query syntax:  This is one of the easy way to write complex syntax in easy and readable format.
    ///                  The syntax for this type of query is like SQL query.
    /// 2.Method syntax: Method syntax uses lambda expressions to define any condition.
    ///                  Method syntax are easy to read/write for simple query.
    ///                  But complex query these are little hard to write as compare to query syntax.
    ///                  In this approach query is written by using multiple methods and combining them with a (.)dot.
    /// 3.Mixed syntax:  This is the combination of query syntax and method syntax.                 
    /// </summary>
    public class WriteALINQuery
    {
        public void QuerySyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = from result in list
                              where result > 2
                              select result;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void MethodSyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = list.Where(result => result > 2);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void MixedSyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var mixedSyntax = (from result in list
                               select result).Max();

            Console.WriteLine("Maximum value = " + mixedSyntax);
            Console.ReadLine();
        }
    }
}
