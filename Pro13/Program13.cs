using static System.Console;

namespace Pro13
{
    internal delegate void OutputProcess(string str);
    
    internal class DelegateUse
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
            WriteLine($" [{data}] ");
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegateUse();
            du.ArrayWalk(data, AddQuote);
        }
    }
}
