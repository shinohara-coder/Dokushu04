using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Pro06
{
    internal class LockBasic
    {
        object lockobj = new object();
        public int Count { get; private set; } = 0;
        static void Main(string[] args)
        {
            const int TaskNum = 500000;
            var ts = new Task[TaskNum];
            var tb = new LockBasic();

            for (int i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            for (int i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            Console.Write(tb.Count);
        }


        private void Increment()
        {
            lock (lockobj)
            {
                this.Count++;
            }
        }
    }

   
}
