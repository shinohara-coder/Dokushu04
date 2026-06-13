using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Pro06
{
    internal class LockBasic
    {
        static void Main(string[] args)
        {
            var dt1 = new DateTime(2026, 6, 13, 22, 3, 45);
            var dt2 = new DateTime(1974, 6, 2, 6, 5, 52);
            var sub = dt1.Subtract(dt2);
            func(sub.ToString("c"));
            func(sub.ToString(@"d\.h\:m\:s"));
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }

        private static void ShowTime(DateTime dt, CultureInfo cul)
        {
            func(dt.ToString("f", cul));
            func(dt.ToString("ggyy/MM/dd dddd tt hh:mm:ss", cul));
        }
    }

    
}
