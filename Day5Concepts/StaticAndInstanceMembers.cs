using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Concepts.StaticAndInstanceMembers
{
    class Member
    {
        float _PI = 3.141f;
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
}
