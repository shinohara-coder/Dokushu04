using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public Coordinate() { }

        public static bool operator true(Coordinate c)
        {
            return c.X >= 0 && c.Y >= 0;
        }

        public static bool operator false(Coordinate c)
        {
            return c.X < 0 || c.Y < 0;
        }

        public override string ToString()
        {
            return $"({this.X,3}, {this.Y,3})";
        }
    }

    internal class PassRefReturn
    {
        static void Main(string[] args)
        {
            var c = new Coordinate() { X = 10, Y = 20 };

            if (c)
            {
                WriteLine($"\"{nameof(c)}\"は真です。");
            }
            else
            {
                WriteLine($"\"{nameof(c)}\"は偽です。");
            }
        }
    }
}

