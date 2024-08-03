using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33Concepts.MultipleInheritance
{
    /// <summary>
    /// C# does not support multiple inheritance because it might raise the issue of ambiguity. 
    /// The ambiguity arises when two parent classes have the same child class, 
    /// and each parent class has a function with the same name.
    /// </summary>
    interface IApple
    {
        void AMethod();
    }
    class Apple : IApple
    {
        public void AMethod()
        {
            Console.WriteLine("Apple");
        }
    }
    interface IBanana
    {
        void BMethod();
    }
    class Banana : IBanana
    {
        public void BMethod()
        {
            Console.WriteLine("Banana");
        }
    }
    class Pineapple : IApple, IBanana
    {
        Apple apple = new Apple();
        Banana banana = new Banana();
        public void AMethod()
        {
            apple.AMethod();
        }
        public void BMethod()
        {
            banana.BMethod();
        }
    }
}
