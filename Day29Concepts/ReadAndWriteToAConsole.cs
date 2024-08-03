using System;

namespace Day29Concepts
{
    /// <summary>
    /// WriteLine => It will print the next output into the next line
    /// Write     => It will prient the next output into the same line
    /// ReadLine  => It is used to read the group of characters from input stream
    ///             and it reads string value
    /// Read      => It is used to read the single character from the input stream
    ///              It reads ASCI value of character
    ///              It returns integer value
    /// </summary>
    class ReadAndWriteToAConsole
    {
        #region DisplayReadAndWrite And Example
        public void DisplayReadAndWrite()
        {
            int number = 12345;
            string name = "Savar Technologies";

            Console.WriteLine(number);
            Console.WriteLine(name);

            Console.WriteLine("Saver");
            Console.WriteLine("Technologies");

            Console.WriteLine("------------------");

            Console.WriteLine("Please Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName");
            string lastName = Console.ReadLine();

            //Concatenation
            Console.WriteLine("Entered FirestName is " + firstName + " and LastName is " + lastName);

            //PlaceHolder Syntax
            Console.WriteLine("Entered FirestName is {0} and LastName is {1} ", firstName, lastName);

            //Interpolation
            Console.WriteLine($"Entered FirestName is {firstName} and LastName is {lastName}");

            Console.WriteLine("Please Enter character");
            int value = Console.Read();

            Console.WriteLine(value);
        }

        public void DisplayReadAndWriteExample()
        {
            int count = 0;
            Console.WriteLine("The Numbers is:");

            for (int i = 1; i < 5; i++)
            {
                count = count + i;
                Console.Write(count + " ");
            }
        }
        #endregion
    }
}
