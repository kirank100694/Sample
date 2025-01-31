﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class WriteALinqQuery
    {
        public static void QuerySyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            foreach( var item in querySyntax )
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void MethodSyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = list.Where(obj =>  obj > 2);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void MixedSyntax()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var mixedSyntax = (from obj in list
                               select obj).Max();

            Console.WriteLine("Max value = " + mixedSyntax);
            Console.ReadLine();
        }
    }
}
