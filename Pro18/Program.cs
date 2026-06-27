using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro18
{
    internal class TupleBasic
    {
        internal (int max, int min) GetMaxMin(int x, int y)
        {
            return (x >= y) ? (x, y) : (y, x);
        }
        static void Main(string[] args)
        {
            var info = new { Title = "速習C#", Price = 1000 };
            func(info.Title);
            func(info.Price);
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
