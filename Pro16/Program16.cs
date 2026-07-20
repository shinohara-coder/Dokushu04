namespace Pro16
{
    internal delegate void OutputProcess(string str);
    internal class DelegateUseCounter
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }
        static void Main(string[] args)
        {
            var data = new[] { "あいうえお", "かきくけこ", "さしすせそ", "たちつてとなにぬねのはひふへほ" };
            var du = new DelegateUseCounter();
            var c = new Counter();
            du.ArrayWalk(data, c.AddLength);
            Console.WriteLine(c.Result);
            Console.WriteLine("----------");
            du.ArrayWalk(data, c.ShowLength);
        }
    }

    internal class Counter
    {
        public int Result { get; private set; }

        public void AddLength(string value)
        {
            Result += value.Length;
        }

        public void ShowLength(string value)
        {
            Console.WriteLine($"\"{value}\"の文字数は{value.Length.ToString().PadLeft(2, ' ')}");
        }
    }
}
