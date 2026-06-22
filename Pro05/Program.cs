using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Pro05
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle() : this(1.0) {}

        public double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }

    internal class MyClass
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double radius))
            {
                Circle c = new Circle(radius);
                Console.WriteLine($"半径{radius}の円の面積は{c.GetArea():F2}です。");
            }
            else
            {
                Console.WriteLine("エラー: 正しい数値を入力してください。");
            }

            
        }
        
        
        
    }

}
