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
            t1.Wait();
            t2.Wait();
            t3.Wait();
            WriteLine("All tasks finished!!");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 50; i++)
            {
                WriteLine($"Task{n}: {i}");
            }
        }
    }
}
