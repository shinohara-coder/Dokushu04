namespace Pro25.hoge
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

    internal class Triangle: Figure
    {
        public Triangle(double width, double height):base(width,height) { }

        //public override double GetArea()
        //{
        //    return this.Width * this.Height / 2;
        //}
    }

    internal class Square: Figure
    {
        public Square(double width, double height) : base(width, height) { }

        //public override double GetArea()
        //{
        //    return this.Width * this.Height;
        //}
    }
    internal partial class TupleBasic
    {   
        static void Main(string[] args)
        {
            Figure t = new Triangle(10, 30);
            Console.WriteLine(t.GetArea());
            Figure s = new Square(10, 30);
            Console.WriteLine(s.GetArea());
        } 
    }
}
