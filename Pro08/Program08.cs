using static System.Console;

namespace Pro08
{
    internal class TryCatchOrder
    {
        internal class Coodinate
        {
            public int X { get; set; }
            public int Y { get; set; }

            public static Coodinate operator +(Coodinate c1, Coodinate c2)
            {
                return new Coodinate()
                {
                    X = c1.X + c2.X,
                    Y = c1.Y + c2.Y
                };
            }

            public override string ToString()
            {
                return $"X:{this.X} Y:{this.Y}";
            }
        }
        static void Main(string[] args)
        {
            var c1 = new Coodinate { X = 10, Y = 20 };
            var c2 = new Coodinate { X = 15, Y = 25 };
            var c3 = c1 + c2;
            var c4 = new Coodinate();
            c4 += c1 + c2;
            WriteLine(c3);
            WriteLine(c4);
        }
    }
}
