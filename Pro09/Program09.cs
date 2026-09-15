using static System.Console;

namespace Pro08
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator ++(Coordinate c)
        {
            return new Coordinate()
            {
                X = c.X + 1,
                Y = c.Y + 1
            };

            //c.X++;
            //c.Y++;
            //return c;
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var a = new Coordinate() { X = 10, Y = 20 };
            var b = ++a;
            WriteLine(a);
            WriteLine(b);
            WriteLine(Object.ReferenceEquals(a, b));

            WriteLine("\n----------------\n");

            var m = new Coordinate() { X = 10, Y = 20 };
            var n = m++;
            WriteLine(m);
            WriteLine(n);
            WriteLine(Object.ReferenceEquals(m, n));
        }
    }
}

