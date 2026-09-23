using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LockBasicBad
    {
        public int Count { get; set; } = 0;

        static void Main(string[] args)
        {
            const int TaskNum = 500000;
            var ts = new Task[TaskNum];
            var tb = new LockBasicBad();

            for (var i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            for (var i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            WriteLine(tb.Count);
        }

        void Increment()
        {
            this.Count++;
        }
    }
}


