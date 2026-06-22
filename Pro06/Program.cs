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
            Console.WriteLine($"円の面積は{r * r * Pi}");
        }

        public static void GetTriAngleArea(int width, int height)
        {
            Console.WriteLine($"三角形の面積は{width * height / 2}");
        }
    }

    internal class LockBasic
    {
        static void Main(string[] args)
        {

        }
    }

    
    }
}
