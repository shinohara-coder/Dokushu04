using System.Diagnostics;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class AsyncReturn
    {
        static void Main(string[] args)
        {
            Task<TimeSpan> t = RunAsync();
            while (!t.IsCompleted)
            {
                t.Wait(100);
                Write(".");
            }
            WriteLine(t.Result);
        }

        static async Task<TimeSpan> RunAsync()
        {
            var watch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                var result = "";
                for (int i = 0; i < 100000; i++)
                {
                    result += "いろは";
                }
            });

            watch.Stop();
            return watch.Elapsed;
        }
    }
}

