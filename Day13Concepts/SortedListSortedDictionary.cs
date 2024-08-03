using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.SortedListSortedDictionary
{
    public static class SortedList
    {
        public static void SortedDictionary()
        {
            var fileInfo = new SortedDictionary<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach(var kvp in fileInfo) 
            {
                Console.WriteLine($"key: {kvp.Key},value: {kvp.Value}");
            }
            Console.WriteLine("Press any key to add another file extension");
            Console.ReadLine();

            fileInfo.Add("bmp", "paint.exe");
            Console.WriteLine("Updated file info list:");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"key: {kvp.Key},value: {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
