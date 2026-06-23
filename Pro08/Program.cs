using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Pro08
{
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            func(MyConfig.Title);
            //MyApp.Title = "hoge";
        }

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}
