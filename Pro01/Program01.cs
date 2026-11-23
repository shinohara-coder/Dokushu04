global using static System.Console;
using System.Security.Cryptography;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(c1.X + c2.X, c1.Y + c2.Y);
        }

        public override string ToString()
        {
            return $"({this.X,3},{this.Y,3})";
        }
    }
    internal class PassRefBasic
    {
        static void Main(string[] args)
        {
            var c1 = new Coordinate(10, 20);
            var c2 = new Coordinate(15, 25);
            var c3 = c1 + c2;
            WriteLine(c3);
        }
    }
}


