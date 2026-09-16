using static System.Console;

namespace Pro12
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator Coordinate(int num)
        {
            return new Coordinate
            {
                X = num,
                Y = num
            };
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var c = (Coordinate)10;
            WriteLine(c);
        }
    }
}

