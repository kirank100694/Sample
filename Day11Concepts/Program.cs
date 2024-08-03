using System;
using System.Linq;
using Day11Concepts.Arrays;
using Day11Concepts.ItemArrays;
using ArrayClass = Day11Concepts;
using Day11Concepts.ModifyItemArray;
using Day11Concepts.ComparingTwoArrays;
using Day11Concepts.Generics;

namespace Day11Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArraysConcept.Arrays();
            ItemArrayConcept.ItemArrays();
            ModifyArrays.ModifyItemArrays();
            ArrayClass.ArrayClassConcept.ArrayClass();
            ComparingArray.ComparingArrays();
            Generics();
        }

        private static void Generics()
        {
            //bool Equal = Calculator.AreEqual(1, 2);
            //bool Equal = Calculator.AreEqual("A", "A");
            bool Equal = Calculator<int>.AreEqual(1, 2);

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
