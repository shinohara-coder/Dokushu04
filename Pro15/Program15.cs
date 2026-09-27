using System.Net.Http.Headers;
using static System.Console;

namespace Pro15
{
    internal class DelegeteMulti
    {
        static void Main(string[] args)
        {
            var data1 = new[] { "い", "ろ", "は" };
            var data2 = new[] { "い", "ろ", "は" };
            WriteLine(data1.Equals(data2));
            WriteLine(data1.SequenceEqual(data2));

            string? str = null;
            str ??= "権兵衛";
            //str = str ?? "山田";
            WriteLine(str);
        }
    }
}