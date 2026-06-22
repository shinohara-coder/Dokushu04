using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Pro06
{
    internal class Figure
    {
        public static double Pi = Math.PI;
        public static void GetCircleArea(double r)
        {
            Console.WriteLine($"円の面積は{r * r * Pi:F4}");
        }

        public static void GetTriAngleArea(double width, double height)
        {
            Console.WriteLine($"三角形の面積は{width * height / 2:F4}");
        }
    }

    internal class LockBasic
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Figure.Pi:F4}");
            Figure.GetCircleArea(5);
            Figure.GetTriAngleArea(3, 5);
        }
    }

    
}
