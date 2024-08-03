using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32Concepts.Polymeorphism
{
    public class Employee
    {
        public string FirstName = "firstName";
        public string LastName = "secondName";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - One Time");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Two Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary");
        }
    }

    public interface Shape
    {
        void Draw();
    }

    // class implementing the interface
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    // Another class that uses polymorphism
    public class DrawingManager
    {
        public void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}
