global using static System.Console;
using System.Security.Cryptography;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Coordinate operator ++(Coordinate c)
        {
            //return new Coordinate(c.X + 1, c.Y + 1);
            //return new Coordinate(c.X++, c.Y++);
            return new Coordinate(++c.X, ++c.Y);
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
            var a = new Coordinate(10, 20);
            var b = a++;
            WriteLine(a);
            WriteLine(b);
        }
    }
}


