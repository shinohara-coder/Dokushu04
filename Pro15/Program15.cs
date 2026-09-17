using System.Net.Http.Headers;
using static System.Console;

namespace Pro15
{
    internal delegate void OutputProcess(string str);
    internal class DelegeteMulti
    {
        void ArrayWalk(string[] data, OutputProcess output)
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
            var dm = new DelegeteMulti();
            OutputProcess? proc = AddQuote;
            proc += Front4;
            dm.ArrayWalk(data, proc);

            WriteLine("---------------------");

            //proc -= Front4;
            proc -= AddQuote;
            dm.ArrayWalk(data, proc!);

            WriteLine("---------------------");

            proc += AddQuote;
            dm.ArrayWalk(data, proc);

            WriteLine("---------------------");

            proc -= AddQuote;
            dm.ArrayWalk(data, proc!);
        }
    }
}