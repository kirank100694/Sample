using System;
using Exceptional = Day14Concepts;
using Type = Day14Concepts;
using Constant = Day14Concepts;
using OutAndRef = Day14Concepts;
using Tuples = Day14Concepts;
using PartialClass = Day14Concepts;
using Debug = Day14Concepts;

namespace Day14Concepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ExceptionHandling.Handling();
            ExceptionType.DisplayType();
            //AsynchronousProgramming.DisplayAsychronous();
            //ConstantAndReadonly.DisplayConstant();
            //OutAndRefMethodParameters.DisplayOutAndRef();
            //Tuples.TuplesExample();
            //ShowPartialClass();
            //DisplayDebugVsRelease();
        }

        public static void ShowPartialClass()
        {
            Helloclass hello = new Helloclass();
            hello.HelloWorld();
            hello.HelloUniverse();
        }

        public static void DisplayDebugVsRelease()
        {
#if DEBUG
            Console.WriteLine(DateTime.Now);
#endif 

            Console.WriteLine("This is your application");
        }
    }
}
