using static System.Console;
using static System.Math;

namespace Pro08
{   
    internal class Coodinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coodinate operator +(in Coodinate c1, in Coodinate c2)
        {
            return new Coodinate()
            {
                X = c1.X + c2.X,
                Y = c1.Y + c2.Y
            };
        }

        //public static Coodinate operator +(Coodinate c, int x)
        //{
        //    return new Coodinate()
        //    {
        //        X = c.X + x,
        //        Y = c.Y
        //    };
        //}

        public override string ToString()
        {
            return $"X: {this.X} Y: {this.Y}";
        }
    }
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var c1 = new Coodinate { X = 10, Y = 20 };
            c1 += new Coodinate() { X = 15, Y = 25 };
            Console.WriteLine(c1);
        }
    }
}
