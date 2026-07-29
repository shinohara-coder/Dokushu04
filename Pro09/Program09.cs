namespace Pro08
{
    internal class MySingleton
    {   
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => Count(1));
            Task t2 = Task.Run(() => Count(2));
            Task t3 = Task.Run(() => Count(3));

            Task.WaitAny(t1, t2, t3);
            //Task.WaitAll(t1, t2, t3);

            Console.WriteLine("すべての処理が終了しました。");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Thread{n}: {i}");
            }
        }
    }
}

