using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.GenericStackInCSharp
{
    /// <summary>
    /// The Generic Stack is a collection class that works on the principle of 
    /// Last In First Out (LIFO) and this class is present in System. Collections. Generic namespace. 
    /// The Generic Stack Collection is used when we need Last In First Out (LIFO) access to items.
    /// </summary>
    public class GenericStack
    {
        public void GenericStackExample()
        {
            var stack = new Stack<string>();
            stack.Push("Item1");
            stack.Push("Item2");
            stack.Push("Item3");

            var popedItem = stack.Pop();

            var peekedValue = stack.Peek();

            stack.Clear();

            Console.ReadKey();
        }
    }

    public class ShoppingCart
    {
        Stack<string> cart = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        public void Add(string itemName)
        {
            cart.Push(itemName);    
        }

        public void Undo() 
        {
            var item = cart.Pop();
            redoStack.Push(item);
        }

        public void Redo()
        {
            var item = redoStack.Pop();
            cart.Push(item);
        }

        public void ViewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t" + item);
            }
        }

        static ShoppingCart _ShoppingCart;
        public void DisplayShppingCart()
        {
            int option = 0;

            _ShoppingCart = new ShoppingCart();

            while (option != 5)
            {
                Console.WriteLine("\n\t\tMenu - Select an option");
                Console.WriteLine("\t\t-----------------------");
                Console.WriteLine("\t\t1. Add an item to shoping cart");
                Console.WriteLine("\t\t2. Undo");
                Console.WriteLine("\t\t3. Redo");
                Console.WriteLine("\t\t4. View cart");
                Console.WriteLine("\t\t5. Exit");
                Console.WriteLine("option: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.WriteLine("Enter item Name(type 'n' to stop):");
                            var itemName = Console.ReadLine();

                            if (itemName != "n")
                                _ShoppingCart.Add(itemName);

                            repeat = itemName == "n" ? false : true;
                        }

                        ShowCartItems();
                        break;

                    case 2:
                        _ShoppingCart.Undo();
                        ShowCartItems();
                        break;

                    case 3:
                        _ShoppingCart.Redo();
                        ShowCartItems();
                        break;

                    case 4:
                        ShowCartItems();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option !");
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void ShowCartItems()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t-----------------");
            _ShoppingCart.ViewCart();
            Console.WriteLine("\t---------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
