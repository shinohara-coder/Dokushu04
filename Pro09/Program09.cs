using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro08
{
    interface IFigure
    {
        double GetArea();
    }

    internal class Triagle : IFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Triagle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double GetArea()
        {
            return this.Width * this.Height / 2;
        }
    }

    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var t = new Triagle(10, 30);
            WriteLine(t.GetArea());
        }
    }
}

