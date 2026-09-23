using static System.Console;

namespace SelfCSharp.Chap02
{
    internal class LockBasicBad
    {
        private object lockobj = new object();
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
            lock(lockobj)
            {
                this.Count++;
            }
        }
    }
}


