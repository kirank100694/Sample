using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.WhyEnumsConcept
{
    /// <summary>
    /// 1.Enums are strongly constaints.
    /// 2.If program uses set of integral numbers consider replacing them with enums.
    /// other wises the program becomes less
    /// Here Gender is like
    /// 0 = Unknown
    /// 1 = Male
    /// 2 = Female
    /// </summary>
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }

    public class WhyEnums
    {
        public void WhyEnumsExample()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 0
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
            static string GetGender(int gender)
            {
                switch (gender)
                {
                    case 0:
                        return "Unknown";
                    case 1:
                        return "Male";
                    case 2:
                        return "Female";
                    default:
                        return "Invalid data detected";
                }
            }
        }
    }
}
