using static System.Console;

namespace Pro12
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var name = "山田";
            WriteLine($@"おはよう、{name}さん！
                        こんにちは、{name}さん！
                        さようなら、{name}さん！");
        }
    }
}

