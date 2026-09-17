using static System.Console;

namespace Pro16
{
    internal delegate string OutputProcess(string str);

    internal class DelegeteMultiResult
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                WriteLine(output(value));
            }
        }
        static string AddQuote(string data)
        {
            return $"［{data}］";
        }

        static string Front4(string data)
        {
            return data.Substring(0, 4);
        }
        static void Main(string[] args)
        {
            var data = new string[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dr = new DelegeteMultiResult();
            OutputProcess proc = AddQuote;
            proc += Front4;
            dr.ArrayWalk(data, proc);
        }
    }
}
