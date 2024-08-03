using System;
using System.Net.NetworkInformation;
using Interface = Day33Concepts.Interfaces;
using Day33Concepts.ExplicitInterfaceImplimentation;
using classes = Day33Concepts.AbstractClasses;
using Day33Concepts.AbstractClassVsInterface;
using Day33Concepts.DiamondProblem;
using Day33Concepts.MultipleInheritance;
using Day33Concepts.OptionalParametersArray;
using Day33Concepts.OptionalParameterMethodOverloading;
using Day33Concepts.OptionalParameterDefault;
using Day33Concepts.OptionalAttributeParameters;
using StringMethod = Day33Concepts.OverrideToStringMethod;
using ToString = Day33Concepts.ConvertToStringAndTostring;
using Day33Concepts.StringAndStringBuilder;
using Day33Concepts.ConstantAndReadonly;
using System.Text;

namespace Day33Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface();
            //InterfaceExample();
            //ExplicitInterfaceExample();
            //DiamondProblem();
            //MultipleInheritences();
            //ParameterArrays();
            //MethodOverload();
            //PerameterDefault();
            //OptionalAttribute();
            //StringMethods();
            StringMethodsExample();
            //ConvertToStrings();
            //StringBuilders();
            //StringBuildersExample();
            //DisplayConstant();


        }

        public static void Interface()
        {
            Interface.Customer customer = new Interface.Customer();
            customer.Print1();
            customer.Print2();

            Interface.ICustomer1 customer1 = new Interface.Customer();
            customer1.Print1();
        }

        public static void InterfaceExample()
        {
            Interface.Hyderabad hyderabad = new Interface.Hyderabad();  
            hyderabad.FamousDish();
        }

        public static void ExplicitInterfaceExample()
        {
            ExplicitInterfaceImplimentation.ExplicitInterface program = new ExplicitInterfaceImplimentation.ExplicitInterface();
            program.InterfaceMethod();
            ((Explicit1)program).InterfaceMethod();
            ((Explicit2)program).InterfaceMethod();

            Explicit1 explicit1 = new ExplicitInterfaceImplimentation.ExplicitInterface();
            explicit1.InterfaceMethod();

            Explicit2 explicit2 = new ExplicitInterfaceImplimentation.ExplicitInterface();
            explicit2.InterfaceMethod();
        }

        public static void AbstractClass()
        {
            classes.Customer customer = new classes.Abstract();
            customer.Print();
        }

        public static void DiamondProblem()
        {
            Dates dates = new Dates();
            dates.Print();
        }

        public static void MultipleInheritences()
        {
            Pineapple pineapple = new Pineapple();
            pineapple.AMethod();
            pineapple.BMethod();
        }

        public static void ParameterArrays()
        {
            ParameterArray.AddNumbers(10, 20, 30, 40, 50);
            ParameterArray.AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }

        public static void MethodOverload()
        {
            MethodOverloading.AddNumbers(10, 20, null);
            MethodOverloading.AddNumbers(10, 20, 30, 40);
        }

        public static void PerameterDefault()
        {
            PerameterDefaults.AddNumbers(10, 20);
            PerameterDefaults.Test(1, c: 2);
        }

        public static void OptionalAttribute()
        {
            OptionalAttributes.AddNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void StringMethods()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            StringMethod.Customer customer = new StringMethod.Customer();
            customer.firstName = "Simon";
            customer.lastName = "Tan";

            Console.WriteLine(Convert.ToString(customer));
        }

        static void StringMethodsExample()
        {
            int id = 100;

            Console.WriteLine(id.ToString());

            StringMethod.Employee employee = new StringMethod.Employee();
            employee.Name = "Kiran";
            Console.WriteLine(employee.ToString());

            employee.departmentName = "Solution Architect";
            Console.WriteLine(employee.ToString());
        }

        public static void ConvertToStrings()
        {
            ToString.Customer customer = null;
            string str = Convert.ToString(customer);
            //string str = customer.ToString();
            Console.WriteLine(str);
        }

        public static void StringBuilders()
        {
            string userString = "C# ";
            userString += "Videos ";
            userString += "Tutorial ";
            userString += "for ";
            userString += "Beginners ";
            Console.WriteLine(userString);

            StringBuilder userstring = new StringBuilder();
            userstring.Append("C# ");
            userstring.Append("Videos ");
            userstring.Append("Tutorial ");
            userstring.Append("for ");
            userstring.Append("Beginners ");
            Console.WriteLine(userString.ToString());
        }

        public static void StringBuildersExample()
        {
            string userString1 = string.Empty;
            for (int i = 1; i <= 50; i++)
            {
                userString1 += i.ToString() + " ";
            }
            Console.WriteLine(userString1);
        }

        public static void DisplayConstant()
        {
            const int value = 100;
            Console.WriteLine(value);

            ConstantAndReadonlyExample constant = new ConstantAndReadonlyExample();
            ConstantAndReadonlyExample constant1 = new ConstantAndReadonlyExample();
            ConstantAndReadonlyExample Cconstant2 = new ConstantAndReadonlyExample();
            ConstantAndReadonlyExample constant3 = new ConstantAndReadonlyExample();
            ConstantAndReadonlyExample constant4 = new ConstantAndReadonlyExample();
        }
    }
}
