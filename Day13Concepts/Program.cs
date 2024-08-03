using System;
using Day13Concepts.Dictionary;
using Day13Concepts.CustomerTypeDictionary;
using Day13Concepts.SortedListSortedDictionary;
using Day13Concepts.GenericStack;
using Day13Concepts.Stack;
using Day13Concepts.BookingSystem;
using Queue = Day13Concepts;
using System.Runtime.Intrinsics.Arm;

namespace Day13Concepts
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Dictionarys.Months();
            CustomerType.Dictionary();
            //SortedList.SortedDictionary();
            //GenericStackConcepts.StackConcept();
            //ShoppingCart.DisplayShoppingCart();
            //GenericQueue.DisplayQueue();
            //DisplayMovieTickets();
        }

        public static void DisplayMovieTickets()
        {
            MovieTicketsBookingSystem bookingSystem = new MovieTicketsBookingSystem();
            bookingSystem.AddToQueue(new Customer { Name = "John", Age = 20 });
            bookingSystem.AddToQueue(new Customer { Name = "Martin", Age = 9 });
            bookingSystem.AddToQueue(new Customer { Name = "Sam", Age = 25 });

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking process started....");
            bookingSystem.ProcessBooking();
            bookingSystem.ProcessBooking();

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("Adding more customers to the queue");
            bookingSystem.AddToQueue(new Customer { Name = "Jili", Age = 16 });
            bookingSystem.AddToQueue(new Customer { Name = "Cristin", Age = 8 });

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("\nBooking process started....");
            bookingSystem.ProcessBooking();
            bookingSystem.ProcessBooking();

            Console.ReadKey();
            bookingSystem.ShowQueue();

            Console.ReadLine();
        }
    }
}
