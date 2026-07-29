using static System.Console;
using static System.Math;

namespace Pro08
{   
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(Count);
            var t2 = new Thread(Count);
            var t3 = new Thread(Count);

            t1.Start(1);
            t2.Start(2);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"メイン処理：{i}");
            }

            t3.Start(3);


            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("全ての処理が終了しました。");
        }

        static void Count(object? n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Thread{n}: {i}");
            }
        }
    }
}
