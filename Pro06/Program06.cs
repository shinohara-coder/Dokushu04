using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro06
{
    internal class AsyncStream
    {
        static void Main(string[] args)
        {
            var list = new[] { 1, 2, 3, 4, 5 };
            //foreach(ref var value in list.AsSpan())
            //{
            //    value *= value;
            //}

            //foreach (var value in list)
            //{
            //    value *= value;
            //}

            for (int i = 0; i < 5; i++)
            {
                list[i] *= list[i];
            }
            WriteLine(string.Join(", ", list));
        }
    }
}
