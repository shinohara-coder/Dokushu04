using System.IO.Pipes;

namespace Pro06
{
    internal class LockBasic
    {
        static void Main(string[] args)
        {
            foreach (var value in args)
            {
                Console.WriteLine($"こんにちは、{value}さん！");
            }
        }
    }   
}
