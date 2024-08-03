using System;
using Private = Day10Concepts.PrivateAndPublicAccessModifier;
using Protected = Day10Concepts.ProtectedAccessModifier;
using Day10Concepts.InternalAndProtectedInternal;
using Enums = Day10Concepts.WhyEnums;
using Example = Day10Concepts.EnumsExample;
using Day10Concepts.EnumsConcepts;
using System.Drawing;

namespace Day10Concepts
{
    public class Program
    {
        private static void Main(string[] args)
        {
            PrivateAndPublic();
            Protected();
            WhyEnums();
            EnumsExample();
            EnumsConcept();
        }

        private static void PrivateAndPublic()
        {
            Private.Customer C1 = new Private.Customer();
            Console.WriteLine(C1.ID);
        }

        private static void Protected()
        {
            Protected.Customer C1 = new Protected.Customer();
            //Console.WriteLine(C1.ID);
        }

        public static void WhyEnums()
        {
            Enums.Customer[] customers = new Enums.Customer[3];

            customers[0] = new Enums.Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customers[1] = new Enums.Customer
            {
                Name = "Mary",
                Gender = 2
            };
            customers[2] = new Enums.Customer
            {
                Name = "Sam",
                Gender = 0
            };

            foreach (Enums.Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}",customer.Name, GetGender(customer.Gender));
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
        
        public static void EnumsExample()
        {
            Example.Customer[] customers = new Example.Customer[3];

            customers[0] = new Example.Customer
            {
                Name = "Mark",
                Gender = Example.Gender.Male
            };
            customers[1] = new Example.Customer
            {
                Name = "Mary",
                Gender = Example.Gender.Female
            };
            customers[2] = new Example.Customer
            {
                Name = "Sam",
                Gender = Example.Gender.Unkown
            };

            foreach (Example.Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }

            static string GetGender(Example.Gender gender)
            {
                switch (gender)
                {
                    case Example.Gender.Unkown:
                        return "Unknown";
                    case Example.Gender.Male:
                        return "Male";
                    case Example.Gender.Female:
                        return "Female";
                    default:
                        return "Invalid data detected";
                }
            }
        }

        public static void EnumsConcept()
        {
            Gender gender = (Gender)3;
            int Num = (int)Gender.UnKnown;

            //Gender gender1 = (Gender)Season.Winter;

            int[] Values = (int[])Enum.GetValues(typeof(Gender));

            //short[] Values = (short[])Enum.GetValues(typeof(Gender));

            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }
            string[] Names = Enum.GetNames(typeof(Gender));

            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
