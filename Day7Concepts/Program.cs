using System;
using WhyProperties = Day7Concepts.WhyProperties;
using Properties = Day7Concepts.Properties;
using Day7Concepts.Structures;
using Day7Concepts.ClassVSStructures;

namespace Day7Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WhyProperties();
            //Properties();
            //Structures();
            ClassVSStructures();
        }

        public static void WhyProperties()
        {
            WhyProperties.Student C1 = new WhyProperties.Student();
            WhyProperties.Students C = new WhyProperties.Students();
            C.setId(101);
            C.SetName("Kiran");
            Console.WriteLine("Student Id = {0}", C.GetId());
            Console.WriteLine("Student Name = {0}", C.GetName());
            Console.WriteLine("PassMark = {0}", C.GetpassMark());

            C1.ID = -101;
            C1.Name = null;
            C1.PassMark = 0;

            Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",
                C1.ID, C1.Name, C1.PassMark);
        }

        public static void Properties()
        {
            Properties.Student C1 = new Properties.Student();
            C1.Id = 101;
            C1.Name = "Kumar";

            Console.WriteLine("Student Id = {0}", C1.Id);
            Console.WriteLine("Student Name = {0}", C1.Name);
            Console.WriteLine("PassMark = {0}", C1.passMark);

            Properties.Students C = new Properties.Students();
            C.Id = 101;
            C.Name = "Kumar";

            Console.WriteLine("Student Id = {0}", C.Id);
            Console.WriteLine("Student Name = {0}", C.Name);
            Console.WriteLine("PassMark = {0}", C.passMark);
        }

        /// <summary>
        /// Object Initialize Syntax In 68th line
        /// </summary>
        public static void Structures()
        {
            Customer S1 = new Customer(100, "Mark");
            S1.PrintDetails();
            Customer S2 = new Customer();
            S2.ID = 101;
            S2.Name = "John";
            S2.PrintDetails();

            Customer S3 = new Customer  
            {
                ID = 102,
                Name = "rob"
            };
            S3.PrintDetails();
        }

        public static void ClassVSStructures()
        {
            int i = 0;
            if (i == 10)
            {
                int j = 20;
                customer K = new customer();
                K.Id = 101;
                K.Name = "Jack";
            }
            Console.WriteLine("Hello");

            int k = 10;
            int L = k;
            L = L + 1;

            Console.WriteLine("i = {0} && j ={1}", k, L);

            customer C = new customer();
            C.Id = 101;
            C.Name = "Jack";

            customer C1 = C;
            C1.Name = "Rose";

            Console.WriteLine("C.Name = {0} && C1.Name = {1}", C.Name, C1.Name);
        }
    }
}

