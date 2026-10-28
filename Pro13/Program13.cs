using System.Text.RegularExpressions;
using static System.Console;

namespace Pro13
{
    internal class Triangle
    {
        private double _width = 0;
        private double _height = 0;

        public Triangle() { WriteLine("Constroctor!!"); }

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

    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.Width = 15;
            t.Height = 8;
            WriteLine($"三角形の面積は{t.GetArea()}です。");
            t.Width = -12;
        }
    }
}
