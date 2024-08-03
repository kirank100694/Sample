using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.SortedListSortedDictionaryInCSharp
{
    /// <summary>
    /// In SortedList, you can access elements using the index. 
    /// In SortedDictionary, you can access elements using index or key. 
    /// Here key access is sufficient there is no need of accessing elements using index. 
    /// In SortedList, data are already in sorted form.
    /// </summary>
    public class SortedListSortedDictionary
    {
        public void SortedListAndSortedDictionary()
        {
            var fileInfo = new SortedDictionary<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");
            fileInfo.Add("pdf", "pdf.exe");

            foreach (var keyvaluepair in fileInfo)
            {
                Console.WriteLine($"key: {keyvaluepair.Key},value: {keyvaluepair.Value}");
            }
            Console.WriteLine("Press any key to add another file extension");
            Console.ReadLine();

            fileInfo.Add("bmp", "paint.exe");
            fileInfo.Add("home", "home.exe");
            fileInfo.Add("vlc", "vlc.exe");
            Console.WriteLine("Updated file info list:");

            foreach (var keyvaluepair in fileInfo)
            {
                Console.WriteLine($"key: {keyvaluepair.Key},value: {keyvaluepair.Value}");
            }
            Console.ReadKey();
        }
    }
}
