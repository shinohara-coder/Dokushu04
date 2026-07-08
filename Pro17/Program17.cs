using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro17
{
    readonly struct Coodinate
    {
        //public readonly double X;
        //public readonly double Y;
        public double X { get; }
        public double Y { get; }

        public Coodinate(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public void SetValue(double c, double y)
        {

        }
    }
    internal class RefForeach
    {
        static void Main(string[] args)
        {
            var c = new Coodinate(10, 20);
            c.SetValue(1, 2);
            Console.WriteLine(c.X);
            Console.WriteLine(c.Y);
        }
    }
}
