using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Pro06
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 15, 30, 60 };
            var list2 = new List<int> { 1, 5, 3, 6 };

            list.Insert(2, 7);
            list.Add(120);

            //list.ForEach(v => func(v));

            //func(list.Count);
            //func(list[0]);
            //func(list.Contains(30));
            //func(list.IndexOf(30));
            //func(list.LastIndexOf(30));
            func(list.Remove(60));
            PrintList(list);

            list.AddRange(list2);
            PrintList(list);

            list.Reverse();
            PrintList(list);

            var ary = new int[3];
            list.CopyTo(2, ary, 0, 3);
            func(string.Join(", ", ary));
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }

        private static void PrintList<T>(List<T> list)
        {
            func(string.Join(", ", list.ToArray()));
        }
    }
}
