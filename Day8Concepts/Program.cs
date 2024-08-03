using System;
using Day8Concepts.IntroductionToInterface;
using Day8Concepts.ExplicitInterfaceImplimentation;
using Day8Concepts.AbstractClass;
using Day8Concepts.AbstractClassesVSInterfaces;
using Day8Concepts.DiamondProblem;
using Day8Concepts.MultipleInheritences;

namespace Day8Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Interface();
            InterfaceImplimentation();
            AbstractClass();
            AbstractClassesVSInterfaces();
            DiamondProblem();
            MultipleInheritences();
        }

        public static void Interface()
        {
            IntroductionToInterface.Customer C1 = new IntroductionToInterface.Customer();
            ICustomer1 Cust = new IntroductionToInterface.Customer();
            Cust.Print1();

            C1.Print1();
            C1.Print2();
        }

        public static void InterfaceImplimentation()
        {
            ExplicitInterfaceImplimentation.Program P = new ExplicitInterfaceImplimentation.Program();
            P.InterfaceMethod();
            ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();

            I1 i1 = new ExplicitInterfaceImplimentation.Program();
            I2 i2 = new ExplicitInterfaceImplimentation.Program();

            i1.InterfaceMethod();
            i2.InterfaceMethod();
        }

        public static void AbstractClass()
        {
            AbstractClass.Customer C = new AbstractClass.Program();
            C.Print();
        }

        public static void AbstractClassesVSInterfaces()
        {

        }

        public static void DiamondProblem()
        {
            D d = new D();
            d.Print();
        }

        public static void MultipleInheritences()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
