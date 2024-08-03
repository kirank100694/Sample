using System;
using Day32Concepts.Inheritance;
using Day32Concepts.MethodHiding;
using Polymeorphims = Day32Concepts.Polymeorphism;
using Day32Concepts.Polymeorphism;
using Methods = Day32Concepts.MethodOverridingVSOverHiding;
using Day32Concepts.MethodOverLoading;
using Day32Concepts.Properties;
using Example = Day32Concepts.Properties;
using Day32Concepts.Structures;
using Day32Concepts.ClassVSStructures;
using System.Runtime.ConstrainedExecution;


namespace Day32Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InheritanceExample();
            //InheritanceExample1();
            //MethodHidingExample1();
            //MethodHidingExample2();
            //Polymeorphims();
            //PolymeorphimsExample();
            //MethodOverridingVSOverHiding();
            //MethodOverLoading();
            //MethodOverLoadingExample();
            //WhyPropertiesExample();
            //Properties();
            //PropertiesExample1();
            //PropertiesExample2();
            //PropertiesExample3();
            ClassVSStructuresExample();
        }

        static void InheritanceExample()
        {
            Inheritance.FullTimeEmployee fullTimeEmployee = new Inheritance.FullTimeEmployee();
            fullTimeEmployee.firstName = "Saver";
            fullTimeEmployee.lastName = "Tech";
            fullTimeEmployee.yearlySalary = 500000;
            fullTimeEmployee.PrintFullName();

            Inheritance.PartTimeEmployee partTimeEmployee = new Inheritance.PartTimeEmployee();
            partTimeEmployee.firstName = "Kiran";
            partTimeEmployee.lastName = "Tech";
            partTimeEmployee.PrintFullName();

            Inheritance.ChildClass childClass = new Inheritance.ChildClass();

        }

        static void InheritanceExample1()
        {
            Manager manager = new Manager();
            manager.Name = "Gopi";
            manager.Company = "Savar Tech";
            manager.Displayinfo();
            manager.Manage();
        }

        static void MethodHidingExample1()
        {
            MethodHiding.FullTimeEmployee fullTimeEmployee = new MethodHiding.FullTimeEmployee();
            fullTimeEmployee.firstName = "FullTime";
            fullTimeEmployee.lastName = "Employee";
            fullTimeEmployee.PrintFullName();

            MethodHiding.PartTimeEmployee partTimeEmployee = new MethodHiding.PartTimeEmployee();
            partTimeEmployee.firstName = "PartTime";
            partTimeEmployee.lastName = "Employee";
            partTimeEmployee.PrintFullName();
        }

        static void MethodHidingExample2()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.StaticMethod();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.StaticMethod();
        }

        static void Polymeorphims()
        {
            Polymeorphims.Employee[] Employees = new Polymeorphims.Employee[4];

            Employees[0] = new Polymeorphism.Employee();
            Employees[1] = new Polymeorphism.FullTimeEmployee();
            Employees[2] = new Polymeorphism.PartTimeEmployee();

            foreach (Polymeorphism.Employee employee in Employees)
            {
                employee.PrintFullName();
            }
        }

        static void PolymeorphimsExample()
        {
            DrawingManager manager = new DrawingManager();

            Shape circle = new Circle();
            manager.DrawShape(circle);

            Shape square = new Square();
            manager.DrawShape(square);
        }

        static void MethodOverridingVSOverHiding()
        {
            Methods.BaseClass baseClass = new Methods.BaseClass();
            baseClass.Print();

            Methods.DerivedClass derivedClass = new Methods.DerivedClass();
            derivedClass.Print();
        }

        public static void MethodOverLoading()
        {
            MethodOverLoadingExample method = new MethodOverLoadingExample();
            //method.Add();
            //method.Add1();
        }

        public static void MethodOverLoadingExample()
        {
            Calculator calculator = new Calculator();
            int add1 = calculator.Add(1, 2);
            int add2 = calculator.Add(3, 4, 5);
            double add3 = calculator.Add(6, 7);
            long add4 = calculator.Add(8, 9, 10);

            Console.WriteLine($"IntSum : {add1}");
            Console.WriteLine($"IntSum : {add2}");
            Console.WriteLine($"DoubleSum : {add3}");
            Console.WriteLine($"LongSum : {add4}");
        }

        public static void WhyPropertiesExample()
        {
            WhyProperties.Students student = new WhyProperties.Students();
            student.setId(101);
            student.SetName("Kiran");
            Console.WriteLine("Student Id = {0}", student.GetId());
            Console.WriteLine("Student Name = {0}", student.GetName());
            Console.WriteLine("PassMark = {0}", student.GetpassMark());

            WhyProperties.Student student1 = new WhyProperties.Student();
            student1.ID = -101;
            student1.Name = "kiran ";
            student1.PassMark = 35;

            Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",
                student1.ID, student1.Name, student1.PassMark);
        }

        public static void Properties()
        {
            Properties.Student C1 = new Properties.Student();
            C1.Id = 101;
            C1.Name = "Kumar";

            Console.WriteLine("Student Id = {0}", C1.Id);
            Console.WriteLine("Student Name = {0}", C1.Name);
            Console.WriteLine("PassMark = {0}", C1.passMark);

            Properties.Students C = new Properties.Students();
            C.Id = 101;
            C.Name = "Kumar";

            Console.WriteLine("Student Id = {0}", C.Id);
            Console.WriteLine("Student Name = {0}", C.Name);
            Console.WriteLine("PassMark = {0}", C.passMark);
        }

        public static void PropertiesExample1()
        {
            Console.WriteLine("This is Read and Write Property");
            Example.Employee employee = new Example.Employee();
            Console.WriteLine("Employee details:" + employee);
            employee.name = "Kiran";
            employee.age = 24;
            Console.WriteLine("Employee details:" + employee);
            employee.age += 1;
            Console.Write("Employee details:" + employee);
        }

        public static void PropertiesExample2()
        {
            Console.WriteLine("");
            Property property = new Property(24);
            Console.WriteLine("My age is: " + property.age);
        }

        public static void PropertiesExample3()
        {
            Console.WriteLine("Number of Objects: {0}", Counter.objects);
            Counter object1 = new Counter();
            Console.WriteLine("Number of Objects: {0}", Counter.objects);
            Counter object2 = new Counter();
            Console.WriteLine("Number of Objects: {0}", Counter.objects);
            Counter object3 = new Counter();
            Console.WriteLine("Number of Objects: {0}", Counter.objects);
        }

        /// <summary>
        /// Object Initialize Syntax In 68th line
        /// </summary>
        public static void Structures()
        {
            Customer customer1 = new Customer(100, "Mark");
            customer1.PrintDetails();
            Customer customer2 = new Customer();
            customer2.ID = 101;
            customer2.Name = "John";
            customer2.PrintDetails();

            Customer customer3 = new Customer
            {
                ID = 102,
                Name = "rob"
            };
            customer3.PrintDetails();
        }

        public static void ClassVSStructures()
        {
            int i = 0;
            if (i == 10)
            {
                int j = 20;
                int m = j;
                m = m + 1;

                Console.WriteLine("i = {0} && j ={1}", j, m);

                customer customer = new customer();
                customer.Id = 101;
                customer.Name = "Jack";
            }
            Console.WriteLine("Hello");

            int k = 10;
            int L = k;
            L = L + 1;

            Console.WriteLine("i = {0} && j ={1}", k, L);

            customer customer1 = new customer();
            customer1.Id = 101;
            customer1.Name = "Jack";

            customer customer2 = customer1;
            customer2.Name = "Rose";

            Console.WriteLine("C.Name = {0} && C1.Name = {1}", customer1.Name, customer2.Name);
        }

        public static void ClassVSStructuresExample()
        {
            Cars cars = new Cars();

            cars.Brand = "Hyundai ";
            cars.Model = "Elite I20";
            cars.Color = "White";

            Console.WriteLine("Name of brand: " + cars.Brand + "\nModel name: " + cars.Model + "\nColor of car: " + cars.Color);
        }
    }
}
