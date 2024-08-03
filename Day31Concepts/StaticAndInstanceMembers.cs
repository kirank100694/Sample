using System;

namespace Day31Concepts.StaticAndInstanceMembers
{
    #region Static and Instance Members
    /// <summary>
    /// Static Member:
    /// 1. Static method is called by its class name.
    /// 2. We can’t use this keyword inside the Static Method.
    /// 3. Static Method uses the memory of Class
    /// Instance Member:
    /// 1. Instance Method is called by making the object of a class.
    /// 2. We can use thiskeyword inside Non Static Method.
    /// 3. Non Static Method uses a memory of an object.
    /// </summary>
    class Member
    {
        float _PI = 3.141f; //Instance Constuctor
        int _Radius;

        public Member(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return this._PI * this._Radius * this._Radius;
        }
    }
    class Circle
    {
        static float _PI = 3.141f; //Static Constuctor
        int _Radius;


        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }
    class Round
    {
        public static float _PI; //Static Constuctor
        int _Radius;

        static Round()
        {
            Console.WriteLine("Static Constuctor Called");
            Round._PI = 3.141f;
        }

        public Round(int Radius)
        {
            Console.WriteLine("Instance Constuctor Called");
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return Round._PI * this._Radius * this._Radius;
        }
    }
    #endregion
}
