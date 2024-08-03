using System;
using System.Collections.Generic;
using Day35Concepts.CustomerClass;
using Day35Concepts.CustomerTestClassData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.CustomTypeAsaDictionary
{
    public class CustomTypeDictionary
    {
        public void Dictionary()
        {
            Dictionary<CountryCode, Ambassador> ambassadors = CustomerTestData.GetDictonaryValue();

            Console.WriteLine("Enter Country Code: ");
            var code = Console.ReadLine();

            if (ambassadors.TryGetValue(new CountryCode(code), out Ambassador ambassador))
            {
                Console.WriteLine($"The ambassador is {ambassador.Name}");
                Console.WriteLine($"The ambassador is {ambassador.Age}");
            }
            else
            {
                Console.WriteLine("The ambassador with the given code does not exist" + "in the dictionary");
            }

            Console.ReadKey();
        }
    }
}
