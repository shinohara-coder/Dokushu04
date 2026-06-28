using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Pro06
{
    internal class Circle
    {
        public double this[double radius]
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
    }

    internal class LockBasic
    {
        static void Main(string[] args)
        {
            var c = new Circle();
            Console.Write($"{c[10]:F4}");
        }
    }

    
}
