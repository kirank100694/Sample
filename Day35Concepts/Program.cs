using System;
using Day35Concepts.Generics;
using Day35Concepts.ListCollectionClassConcept;
//using Day35Concepts.ListClassFunctions;
using Day35Concepts.ListClassRange;
using Day35Concepts.ListOfSimpleType;
using Day35Concepts.ListOfComplexType;
using System.Numerics;
using Day35Concepts.ComplexTypeUsingComparisionDelegate;
using Day35Concepts.DictionarysInCSharp;
using Day35Concepts.CustomTypeAsaDictionary;
using Day35Concepts.SortedListSortedDictionaryInCSharp;
using Day35Concepts.GenericStackInCSharp;
using Day35Concepts.GenericQueueInCSharp;
using Day35Concepts.ListClassFunctions;

namespace Day35Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generics();

            //ListCollectionClass listCollectionClass = new ListCollectionClass();
            //listCollectionClass.DisplayCollectionClass();

            ClassFunction classFunction = new ClassFunction();
            classFunction.DisplayClassFunction();
            classFunction.ExistsExample();

            //ClassRange classRange = new ClassRange();
            //classRange.DisplayCustomer();

            //SimpleType simpleType = new SimpleType();
            //simpleType.SimpleTypeExample();

            //ComplexType complexType = new ComplexType();
            //complexType.ComplexTypeExample();

            ComparisionDelegate comparisionDelegate = new ComparisionDelegate();
            comparisionDelegate.ComparisionDelegateExample();

            //Dictionarys dictionarys = new Dictionarys();
            //dictionarys.Months();

            CustomTypeDictionary customTypeDictionary = new CustomTypeDictionary();
            customTypeDictionary.Dictionary();

            //SortedListSortedDictionary sortedListSortedDictionary = new SortedListSortedDictionary();
            //sortedListSortedDictionary.SortedListAndSortedDictionary();

            //GenericStack genericStack = new GenericStack();
            //genericStack.GenericStackExample();

            //ShoppingCart shoppingCart = new ShoppingCart();
            //shoppingCart.DisplayShppingCart();

            //GenericQueue genericQueue = new GenericQueue();
            //genericQueue.DisplayGenericQueue();

            //MovieTicketsBookingSystem movieTickets = new MovieTicketsBookingSystem();
            //movieTickets.DisplayMovieTickets();
        }

        private static void Generics()
        {
            //bool Equal1 = Calculator.AreEqual(1, 2);
            //bool Equal2 = Calculator.AreEqual("A", "B");
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
