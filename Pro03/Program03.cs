using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var list = new[] { 10, 20, 30, 40, 50, 60 };

            var sp = new Span<int>(list, 2, 3);
            foreach(var v in sp)
            {
                WriteLine(v);
            }

            sp[1] = 999;
        }
    }
}

