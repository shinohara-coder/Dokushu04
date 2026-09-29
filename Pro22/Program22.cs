using static System.Console;

namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            foreach(var val in args)
            {
                WriteLine($"こんにちは、{val}さん！");
            }
        }
    }
}
