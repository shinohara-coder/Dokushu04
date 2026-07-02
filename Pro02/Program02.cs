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
        
    internal class LambdaCapture
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
        static void Main(string[] args)
        {
            
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}

