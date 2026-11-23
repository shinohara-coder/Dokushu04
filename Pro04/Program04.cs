using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    delegate void Process(string str);

    internal class PassOut
    {
        static void Run(string s)
        {
            WriteLine($"{s}走ります。");
        }
        static void Main(string[] args)
        {
            //var p = new Process(Run);
            Process p = Run;
            p("とことこ");
        }
    }
}

