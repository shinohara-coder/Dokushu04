using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro04
{
    interface IFigure
    {
        double GetArea();
    }

    internal class Triangle : IFigure
    {
        public double Width { get; set; }
        public double Heiht { get; set; }

        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Heiht = height;
        }

        public double GetArea()
        {
            return this.Width * this.Heiht / 2;
        }
    }

    internal class Program04
    {
        static void Main(string[] args)
        {
            var t = new Triangle(10, 30);
            Console.WriteLine(t.GetArea());
        }
    }
}
