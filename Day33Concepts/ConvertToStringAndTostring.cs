using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.ConvertToStringAndTostring
{
    /// <summary>
    /// Convert.Tostring: is handless null
    /// Tostring        : is doesn't handle null and throw a null referance exception.
    /// Depending on the type of the application architecture and what yo are trying to achive
    /// you choose one over the other.
    /// </summary>
    public class Customer
    {
        public string FirstName { get; set; }
    }
}
