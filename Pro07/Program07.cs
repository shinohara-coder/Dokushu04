using static System.Console;

namespace Pro07
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
        public Square(double width, double height) : base(width, height) { }

        //public override double GetArea()
        public new double GetArea()
        {
            return this.Width * this.Height;
        }
    }

    internal class TupleBasic
    {
        static void Main(string[] args)
        {
            Figure t = new Triangle(10, 30);
            WriteLine(t.GetArea());
            Figure s = new Square(10, 30);
            WriteLine(s.GetArea());
        }
    }
}
