using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.ItemArrays
{
    public static class ItemArrayConcept
    {

        /// <summary>
        /// Operations:
        /// Finding an item array
        /// </summary>
        public static void ItemArrays()
        {
            string[] arrPlanets = {"Mercury", "Venus", "Earth", "Mars", "Jupitar"
                        ,"Saturn", "Uranus", "Neptune"
            };

            Console.WriteLine("Type the plants no. you want to see");
            Console.WriteLine("1 = Mercury");
            Console.WriteLine("2 = Venus");
            Console.WriteLine("3 = Earth..");

            var planetNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(arrPlanets[planetNumber - 1]);

            Console.ReadKey();
        }
    }
}
