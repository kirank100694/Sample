using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34Concepts.ArraysConcept
{
    public static class Arrays
    {
        /// <summary>
        /// Arrays have fixed size because of memory allowcation "System Memory"
        /// Characteristics:
        /// Arrays have fixed length
        /// Arrays are zero-indexed
        /// Operations:
        /// Declaring array
        /// Enumerating array
        /// </summary>
        public static void ArraysExample()
        {
            string[] cars = new string[3] { "Volovo", "BMW", "Ford" };

            int[] myNumbers = new int[3] { 10, 20, 30 };

            string[] cars1 = { "Volovo", "BMW", "Ford" };

            int[] myNumbers1 = { 10, 20, 30 };

            string[] cars2 = new string[10];
            string[] car2 = new string[10];
            car2[0] = "Volvo";
            car2[1] = "BMW";
            car2[2] = "Ford";
            car2[3] = "Toyota";

            string[] arrPlanets = {"Mercury", "Venus", "Earth", "Mars", "Jupitar"
                        ,"Saturn", "Uranus", "Neptune"};


            Console.WriteLine("Months of the year using foreach loop:");

            foreach (var planet in arrPlanets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("\n\nMonths of the year using foreach loop:");
            for (int i = 0; i < arrPlanets.Length; i++)
            {
                Console.WriteLine(arrPlanets[i]);
            }

            Console.ReadKey();
        }
    }
}
