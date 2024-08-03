using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class SingleVSSingleOrDefaultMethod
    {
        public static void SimpleExampleOfSingleVSSingleOrDefaultMethod()
        {
            List<int> numbers = new List<int>() {1 };

            var methodSyntax = numbers.Where(x => x > 1).Single();

            var MethodSyntax1 = numbers.SingleOrDefault();
        }
    }
}
