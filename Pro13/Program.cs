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

            hs.ExceptWith(new HashSet<int> { 15, 30 });
            PrintSet(hs);

            hs.UnionWith(new HashSet<int> { 10, 15, 30 });
            PrintSet(hs);

            hs.SymmetricExceptWith(new HashSet<int> { 1, 10, 30 });
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
