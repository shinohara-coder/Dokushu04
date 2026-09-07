using static System.Console;

namespace Pro15
{
    readonly struct Coodinate
    {
        //public readonly double X;
        //public readonly double Y;

        public double X { get; }
        public double Y { get; }

        public Coodinate(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public void SetValue(double x, double y)
        {
            //this = new Coodinate(x, y);
        }
    }
    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var c = new Coodinate(10, 20);
            c.SetValue(1, 2);
            //c.X = 10;
            WriteLine($"X:{c.X} Y:{c.Y}");
        }
    }
}