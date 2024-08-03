using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.EnumsExample
{
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Unkown,
        Male,
        Female
    }
}
