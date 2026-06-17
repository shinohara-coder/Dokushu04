using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pro13
{
    
    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 10, 15, 20, 30 };
            hs.IntersectWith(new HashSet<int>() { 1, 10, 20, 30, 60 });
            PrintSet(hs);

        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static void PrintSet<T>(HashSet<T> set)
        {
            func(string.Join(", ", set.ToArray()));
        }
    }



}
