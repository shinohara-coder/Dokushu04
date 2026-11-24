using Pro06.Extension;
using static System.Console;

namespace Pro06
{
    delegate void OutputProcess(string str);

    internal class DelegateMulti
    {
        internal void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            WriteLine($"［{data}］");
        }

        static void Front4(string data)
        {
            WriteLine(data.Substring(0, 4));
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegateMulti();
            OutputProcess? proc = AddQuote;
            proc += Front4;
            proc += AddQuote;
            proc += Front4;
            //proc -= Front4;
            //proc -= AddQuote;
            //proc -= Front4;

            dm.ArrayWalk(data, proc);
        }
    }
}
