using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            //WriteLine(Math.Round(1234.56, MidpointRounding.AwayFromZero));
            //WriteLine(Math.Sign(100));

            var rn = new Random();
            //WriteLine(rn.Next());
            //WriteLine(rn.Next(100));
            //WriteLine(rn.Next(100, 200));
            //WriteLine(rn.NextInt64());
            //WriteLine(rn.NextSingle());
            //WriteLine(rn.NextDouble());
            var data = new byte[8];
            rn.NextBytes(data);
            foreach(var b in data)
            {
                WriteLine(b);
            }
        }
    }
}


