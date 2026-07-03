//#define DEBUG
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double GetArea()
        {
            return 0.0;
        }
    }

    internal class Triangle : Figure
    {
        public Triangle(double width, double height) : base(width, height) { }

        //public override double GetArea()
        public new double GetArea()
        {
            return this.Width * this.Height / 2;
        }
    }

    internal class Square : Figure
    {
        public Square(double width, double height)
            : base(width, height) { }

        //public override double GetArea()
        public new double GetArea()
        {
            return this.Width * this.Height;
        }
    }

    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            Figure t = new Triangle(10, 30);
            Console.WriteLine(t.GetArea());
            Figure s = new Square(10, 30);
            Console.WriteLine(s.GetArea());
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

