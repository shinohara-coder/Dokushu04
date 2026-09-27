using System.Diagnostics;
using System.Text;
using static System.Console;

namespace Pro14
{
    internal class DelegeteUseCounter
    {
        static void Main(string[] args)
        {
            const long LIMIT = 5000000000;
            //var sw1 = Stopwatch.StartNew();

            //var result = "";
            //for (int i =0;i<LIMIT;i++)
            //{
            //    result += "いろは";
            //}
            //sw1.Stop();

            var sw2 = Stopwatch.StartNew();
            var builder = new StringBuilder();
            for (long i = 0; i < LIMIT; i++)
            {
                builder.Append("いろは");
            }
            sw2.Stop();

            //WriteLine($"経過時間1: {sw1.ElapsedMilliseconds} ms");
            WriteLine($"経過時間2: {sw2.ElapsedMilliseconds} ms");
        }
    }
}
