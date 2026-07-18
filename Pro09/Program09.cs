using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Pro08
{
    internal class Coodinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coodinate operator ++(Coodinate c)
        {
            return new Coodinate()
            {
                X = c.X + 1,
                Y = c.Y + 1
            };
        }

        public override string ToString()
        {
            return $"X: {this.X} Y: {this.Y}";
        }
    }
    internal class MySingleton
    {   
        static void Main(string[] args)
        {
            var a = new Coodinate() { X = 10, Y = 20 };
            var b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("----------------------");

            var m = new Coodinate() { X = 10, Y = 20 };
            var n = m++;
            Console.WriteLine(m);
            Console.WriteLine(n);
        }
    }
}

