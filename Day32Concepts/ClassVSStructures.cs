using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.ClassVSStructures
{
    /// <summary>
    /// 1. A struct is a value type as a class is a referance type.
    /// 2. Struct are stored on stack, where as classes are stored on heap.
    /// 3. Value type hold their value in memory where they are declared, 
    ///    but referance type hold a reference to an object in memory.
    /// 4. Value types are destroyed immediately  after the scope is lost,
    ///    where as for reference types only the reference variable is detroyed after the scop is lost.
    ///    The object is later destroyed by garbage collector.
    /// </summary>
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Cars
    {
        public string Brand;
        public string Model;
        public string Color;
    }
}
