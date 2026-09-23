using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            Task t = RunAsync();
            //WriteLine("...他の処理...");
            for (var i = 0; i < 50; i++)
            {
                WriteLine($"同期処理: {i}");
            }
            //t.Wait();
        }

        static async Task RunAsync()
        {
            await Task.Run(() => Count(1));
            WriteLine("処理が終了しました。");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 5000; i++)
            {
                WriteLine($"Task{n}: {i}");
            }
        }
    }
}

