using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class AsyncReturn
    {
        static void Main(string[] args)
        {
            var animals = new[] { "とら", "うさぎ", "たつ" };
            var list = new LinkedList<string>(animals);

            foreach (var v in list)
            {
                func(v);
            }

            func(list.Count);
            func(list.Contains("うま"));

            list.AddFirst("ねずみ");
            list.AddLast("いのしし");
            list.AddBefore(list.Last, "いぬ");
            list.AddAfter(list.First, "うし");
            PrintList(list);

        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }

        static void PrintList<T>(LinkedList<T> list)
        {
            func(string.Join(", ", list.ToArray()));
        }
    }
}
