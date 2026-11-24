global using static System.Console;

namespace Pro07
{
    internal delegate string OutputProcess(string str);
    internal delegate void Process(object obj);

    internal class DelegateMultiResult
    {
        Process p = WriteLine;
        
        internal void ArrayWalk(string[] data,OutputProcess output)
        {
            foreach (var value in data)
            {
                p(output(value));
            }
        }

        internal static string AddQuote(string data)
        {
            return $" [{data}] ";
        }

        internal static string Front4(string data)
        {
            return data.Substring(0, 4);
        }


        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dr = new DelegateMultiResult();
            OutputProcess? proc = AddQuote;
            proc += Front4;
            proc += AddQuote;
            //proc -= AddQuote;
#pragma warning disable CS8604 // Null 参照引数の可能性があります。
            dr.ArrayWalk(data, proc);
#pragma warning restore CS8604 // Null 参照引数の可能性があります。
        }
    }
}
