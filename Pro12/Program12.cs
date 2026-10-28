using System.Text.RegularExpressions;
using static System.Console;

namespace Pro12
{
    internal class Triangle
    {
        private double _width = 0.0;
        private double _height = 0.0;

        public Triangle() { }

        public double GetWidth()
        {
            return this._width;
        }

        public void SetWidth(double width)
        {
            if (width <= 0)
            {
                throw new ArgumentException("正数で指定してください。");
            }
            this._width = width;
        }

        public double GetHeight()
        {
            return this._height;
        }

        public void SetHeight(double height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("正数で指定してください。");
            }
            this._height = height;
        }

        public double GetArea()
        {
            return this._width * this._height / 2;
        }
    }


    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.SetWidth(15);
            t.SetHeight(12);
            WriteLine($"三角形の面積は{t.GetArea()}です。");
            t.SetWidth(-9);
        }
    }
}

