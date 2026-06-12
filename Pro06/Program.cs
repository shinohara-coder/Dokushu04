using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class LockBasic
    {
        static void Main(string[] args)
        {
            DateTime dt = default;
            func(dt);
            if (DateTime.TryParse("2026/6/12 21:25:49", out dt))
            {
                func(dt);
            }
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }

    
}
