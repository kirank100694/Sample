using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day13Concepts.BookingSystem
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class MovieTicketsBookingSystem
    {
        Queue<Customer> _queue;
        public MovieTicketsBookingSystem()
        {
            _queue = new Queue<Customer>();
        }

        public void AddToQueue(Customer customer)
        {
            _queue.Enqueue(customer);
            Thread.Sleep(1000);
            Console.WriteLine($"Added to queue: {customer.Name}");
        }
        public void ProcessBooking()
        {
            if(_queue.Any())
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
            foreach(var customer in _queue) 
            {
                Thread.Sleep(500);
                Console.WriteLine("\t" + customer.Name);
            }
        }

        
    }
}
