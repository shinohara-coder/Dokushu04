using static System.Console;


namespace Pro25
{
    internal partial class MyPartialMethod
    {        
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => Count(1));
            Task t2 = Task.Run(() => Count(2));
            Task t3 = Task.Run(() => Count(3));

            //for (int i = 0; i < 1000; i++)
            //{
            //    WriteLine($"途中の処理：{i}");
            //}

            //Task.WaitAny(t1, t2, t3);
            Task.WaitAll(t1, t2, t3);

            WriteLine("All tasks finished!!");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 100; i++)
            {
                WriteLine($"Task{n}: {i}");
            }
        }
    }
}
