using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro10
{
    internal class Coodinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static implicit operator Coodinate(int num)
        {
            return new Coodinate()
            {
                X = num,
                Y = num
            };
        }

        public override string ToString()
        {
            return $"X: {this.X} Y: {this.Y}";
        }
    }
    internal class TypeGetBasic
    {
        static void Main(string[] args)
        {
            Coodinate c = 25;
            Console.WriteLine(c);
        }
    }

}
