using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            Task t = RunAsync();
            Console.WriteLine("...他の処理...");
            t.Wait();
        }

        static async Task RunAsync()
        {
            await Task.Run(() => Count(1));
            Console.WriteLine("処理が修了しました。");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Task{n}: {i}");
            }
        }
    }
}
