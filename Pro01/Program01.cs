using System.Diagnostics;
using System.Text;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            const int Count = 100_000;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            var sw = Stopwatch.StartNew();
            var result = "";
            for (int i = 0; i < Count; i++)
            {
                result += "いろは";
            }
            sw.Stop();
            Console.WriteLine($"経過時間1: {sw.ElapsedMilliseconds} ms");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            //sw.Reset();
            result = "";
            sw.Restart();
            var builder = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                builder.Append("いろは");
            }
            result = builder.ToString();
            sw.Stop();
            Console.WriteLine($"経過時間2: {sw.ElapsedMilliseconds} ms");
        }
    }
}


