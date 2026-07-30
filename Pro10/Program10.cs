namespace Pro10
{
    internal class LockBasicBad
    {
        public int Count { get; private set; } = 0;
        static void Main(string[] args)
        {
            const int TaskNum = 500000;
            var ts = new Task[TaskNum];
            var tb = new LockBasicBad();

            for (int i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            for (int i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            Console.WriteLine(tb.Count);
        }

        private void Increment()
        {
            this.Count++;
        }
    }
}

