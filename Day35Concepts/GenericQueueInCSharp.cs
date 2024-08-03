using System;
using System.Collections.Generic;
using System.Linq;
using Class = Day35Concepts.CustomerClass;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day35Concepts.GenericQueueInCSharp
{
    /// <summary>
    /// Queue represents a first-in, first out collection of object. 
    /// It is used when you need a first-in, first-out access of items. 
    /// When you add an item in the list, it is called enqueue, and when you remove an item, it is called dequeue . 
    /// This class comes under System.
    /// </summary>
    public class GenericQueue
    {
        public void DisplayGenericQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");

            var task = queue.Dequeue();

            var peekedtask = queue.Peek();

            queue.Clear();

            Console.ReadKey();
        }
    }

    public class MovieTicketsBookingSystem
    {
        Queue<Class.Customer> _queue;
        public MovieTicketsBookingSystem()
        {
            _queue = new Queue<Class.Customer>();
        }

        public void AddToQueue(Class.Customer customer)
        {
            _queue.Enqueue(customer);
            Thread.Sleep(1000);
            Console.WriteLine($"Added to queue: {customer.Name}");
        }

        public void ProcessBooking()
        {
            if (_queue.Any())
            {
                var customer = _queue.Dequeue();
                Thread.Sleep(1000);
                Console.WriteLine($"Processed booking for:{customer.Name}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\n\tCurrent queue");
            Console.WriteLine("\t-------------------");
            foreach (var customer in _queue)
            {
                Thread.Sleep(500);
                Console.WriteLine("\t" + customer.Name);
            }
        }

        public void DisplayMovieTickets()
        {
            MovieTicketsBookingSystem bookingSystem = new MovieTicketsBookingSystem();
            bookingSystem.AddToQueue(new Class.Customer { Name = "John", Age = 20 });
            bookingSystem.AddToQueue(new Class.Customer { Name = "Martin", Age = 9 });
            bookingSystem.AddToQueue(new Class.Customer { Name = "Sam", Age = 25 });

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
            bookingSystem.AddToQueue(new Class.Customer { Name = "Jili", Age = 16 });
            bookingSystem.AddToQueue(new Class.Customer { Name = "Cristin", Age = 8 });

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
