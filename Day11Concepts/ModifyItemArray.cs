using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.ModifyItemArray
{
    public static class ModifyArrays
    {

        /// <summary>
        /// Operations:
        /// Modify Array item 
        /// Common Exception in an Array
        /// </summary>
        public static void ModifyItemArrays()
        {
            string[] arrPlanets = new string[2];
            arrPlanets[0] = "Mercury";
            arrPlanets[1] = "Venus";
            arrPlanets[2] = "Earth";

            string[] arrPlanets1 = {"Mercury", "Venus", "Earth", "Mars", "Jupitar"
                        ,"Saturn", "Uranus", "Neptune"
            };

            Console.WriteLine("Type the plants no. you want to see");
            Console.WriteLine("1 = Mercury");
            Console.WriteLine("2 = Venus");
            Console.WriteLine("3 = Earth..");

            arrPlanets[0] = "Mercury Planet";

            foreach (var item in arrPlanets)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        
        
    }        
}


