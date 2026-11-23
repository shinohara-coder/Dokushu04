using Pro05;
using System.Diagnostics;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    delegate void OutputProcess(string str);
    delegate void Process(object obj);
    internal class DelegateUse
    {
        void ArrayWalk(string[] data,OutputProcess output)
        {
            foreach(var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            WriteLine($" [{data}] ");
        }
        
        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegateUse();
            var c = new Counter();
            du.ArrayWalk(data, c.AddLength);
            Process proc = WriteLine;
            proc(c.Result);

            du.ArrayWalk(data, AddQuote);
            du.ArrayWalk(data, s => { WriteLine(s); });
        }
    }

    internal class Counter
    {
        public int Result { get; private set; } = 0;

        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
}

