using Pro05;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var data = "ありがとう";
            WriteLine(data.Repeat(8));
        }
    }
}

