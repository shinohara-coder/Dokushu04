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
            WriteLine($"From: {file}\n{member} \n{line}行目 \nArgs: {arg}");
        }
        static void Main(string[] args)
        {
            ShowCaller("TEST", "file_00", "member_00", 100, "arg00");
        }
    }
}

