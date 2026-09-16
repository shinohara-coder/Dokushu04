using static System.Console;

namespace Pro12
{
    delegate void Process(string str);
    internal class LockBasicBad
    {
        static void Run(string s)
        {
            WriteLine($"{s}走ります。");
        }
        static void Main(string[] args)
        {
            //var p = new Process(Run);
            Process p = WriteLine;
            var strArray = new string[] { "はあはあ", "ちょこちょこ", "すたすた" };
            foreach (var s in strArray)
            {
                p(s);
            }
        }
    }
}

