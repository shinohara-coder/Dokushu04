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
    internal class Triangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("正数で指定してください。");
                }
                this._width = value;
            }

            get { return this._width; }
        }

        public double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("正数で指定してください。");
                }
                this._height = value;
            }

            get { return this._height; }
        }

        public double GetArea()
        {
            return Width * Height / 2;
        }
    }
    
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.Width = 10;
            t.Height = 5;
            Console.WriteLine($"三角形の面積は{t.GetArea()}です。");
            t.Width = -20;
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

