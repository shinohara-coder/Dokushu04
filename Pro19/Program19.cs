using System.Runtime.CompilerServices;

namespace Pro19
{
    
    internal class DelegateAnonymous
    {
        public static void ShowCaller(
            string msg,
            [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0,
            [CallerArgumentExpression("msg")] string arg = "")
        {
            Console.WriteLine($"Form: {file}/{member} {line}行目 Args: {arg}");
        }
        static void Main(string[] args)
        {
            ShowCaller("TEST");
        }

    }
}
