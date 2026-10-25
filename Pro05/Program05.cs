using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var result = 0;
            var sum = 0;

            for (ref var i = ref result; i < 100; i++)
            {
                sum += i;
                if (sum > 1000)
                {
                    break;
                }
            }

            WriteLine($"合計が1000を越えるのは、1～{result}を加算した時です。");
        }
    }
}

