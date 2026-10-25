using IronPython.Runtime;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro07
{
    internal class TupleBasic
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
        }
        static void Main(string[] args)
        {
            var a = new TupleBasic();
            //var t = a.GetMaxMin(23, 45);
            //WriteLine(t.max);
            //WriteLine(t.min);

            var (resultMax, resultMin) = a.GetMaxMin(12, 45);
            Write($"最大値：{resultMax} 最小値：{resultMin}");
        }
    }
}
