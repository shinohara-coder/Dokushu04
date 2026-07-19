using IronPython.Hosting;
using Microsoft.Scripting;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Pro10
{
    internal class Coodinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator int(Coodinate c)
        {
            return c.X * c.X+ c.Y * c.Y;
        }

        public override string ToString()
        {
            return $"X: {this.X} Y: {this.Y}";
        }
    }
    
    internal class ArgParams
    {
        static void Main(string[] arngs)
        {
            var c = new Coodinate() { X = 10, Y = 20 };
            Console.WriteLine((int)c);
        }
    }

}
