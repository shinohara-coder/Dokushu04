using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro21
{
    internal class LambdaMember
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (var i = 0.1f; i <= 10.0; i += 0.1f)
            {
                WriteLine($"値：{i} {++count}回目");
            }
        }
    }
}
