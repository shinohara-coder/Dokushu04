using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro17
{
    internal class RefForeach
    {
        static void Main(string[] args)
        {
            var list = new[] { 1, 2, 3, 4, 5 };
            foreach(ref var value in list.AsSpan())
            {
                value *= value;
            }
            func(string.Join(", ", list));
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
