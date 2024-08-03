using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public static class ExtensionMethods
    {
        public static void DisplayExtensionMethod()
        {
            string strName = "saver";
            //string result = strName.ChangeFirstLetterCase();

            string result = StringHelper.ChangeFirstLetterCase(strName);

            Console.WriteLine(result);
        }

        public static void DisplayEnumerable()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);

            foreach(int evenNumbers in EvenNumbers)
            {
                Console.WriteLine(evenNumbers);
            }
        }
    }
}
