using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class AsyncReturn
    {
        static void Main(string[] args)
        {
            Task<TimeSpan> t = RunAsync();
            while (!t.IsCompleted)
            {
                t.Wait(200);
                Console.Write(".");
            }
            Console.WriteLine(t.Result);
            }

        static async Task<TimeSpan> RunAsync()
        {
            var watch = Stopwatch.StartNew();
            await Task.Run(() =>
            {
                string result = "";
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
