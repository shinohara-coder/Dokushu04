using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = (Coordinate)20;
            Console.WriteLine($"({c.X}, {c.Y})");
        }
    }

    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator Coordinate(int num)
        {
            return new Coordinate()
            {
                X = num,
                Y = num
            };
        }
    }
}
