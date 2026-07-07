using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pro13
{
    
    internal class PassRefBasic
    {
        enum Season : long
        {
            Spring = 255,
            Summer,
            Autumn,
            Winter,
            All = Spring + Summer + Autumn + Winter,
        }
        static void Main(string[] args)
        {
            var s = Season.All;
            Console.WriteLine(s);
            Console.WriteLine(s.ToString());
            Console.WriteLine(s.ToString("D"));
            Console.WriteLine(s.ToString("X"));
            Console.WriteLine(s.ToString("G"));
        }
    }



}
