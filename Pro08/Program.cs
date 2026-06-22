using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class MyApp
    {
        public static readonly string Title = "独習C#";
    }

    internal class MySingleton
    {
        static void Main(string[] args)
        {
            func(MyApp.Title);
            //MyApp.Title = "hoge";
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}
