using System.Runtime.CompilerServices;
using static System.Console;

namespace Pro08
{
    internal class MySingleton
    {
        public static void ShowCaller(
            string msg,
            [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0,
            [CallerArgumentExpression("msg")] string arg = ""
            )
        {
            WriteLine($"From: {file}/{member} {line}行目 Args: {arg}");
        }
        static void Main(string[] args)
        {

        }
    }
}

