using static System.Console;

namespace Pro14
{
    internal delegate void OutputProcess(string str);

    internal class DelegeteUseCounter
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
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegeteUseCounter();
            var c = new Counter();
            du.ArrayWalk(data, c.AddLength);
            WriteLine(c.Result);
        }
    }

    internal class Counter
    {
        public int Result { get; private set; }
        
        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
}
