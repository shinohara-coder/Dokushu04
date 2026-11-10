global using static System.Console;

namespace Pro23
{
    internal class ArgsParams
    {
        internal static void Hoge() => throw new NotSupportedException("未実装です");
        
        static void Main(string[] args)
        {
            //var i = -10;
            //WriteLine(i > 0 ? i : throw new Exception($"{nameof(i)}は正数でなければなりません。"));

            //var i = 0;
            //var j = i > 0 ? null : throw new Exception("...");

            Hoge();
            
            string? str = null;
            WriteLine(str ?? throw new Exception($"{nameof(str)}がnullです。"));
        }
    }
}

