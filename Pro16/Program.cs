using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro16
{
    internal struct Coodinate
    {
        public double X;
        public double Y;

        public Coodinate(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    internal class PassReIn
    {
        public static void Show(in Coodinate c)
        {
            func($"[{c.X}, {c.Y}]");
            //c.X = 10;
        }
        static void Main(string[] args)
        {
            Show(new Coodinate(10, 15));
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
