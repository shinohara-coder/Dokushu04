using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro10
{
    internal class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 20, 30, 60, 10, 15 };
            hs.Add(10);
            hs.Add(5);
            hs.Remove(60);

            foreach (var v in hs)
            {
                func(v);
            }

            func(hs.Count);
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }

}
