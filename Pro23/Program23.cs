global using static System.Console;

namespace Pro23
{
    internal class ArgsParams
    {
        static void Main(string[] args)
        {
            //var i = -10;
            //WriteLine(i > 0 ? i : throw new Exception($"{nameof(i)}は正数でなければなりません。"));

            string? str = null;
            WriteLine(str ?? throw new Exception($"{nameof(str)}がnullです。"));
        }
    }
}

