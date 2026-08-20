using System.Text.RegularExpressions;

namespace Pro16
{
    internal class ArgsParams
    {
        public int TotalProducts(params int[] values)
        {
            int result = 1;
            foreach (var value in values)
            {
                result *= value;
            }
            return result;
        }
        static async Task Main(string[] args)
        {
            var v = new ArgsParams();
            Console.WriteLine(v.TotalProducts(12, 15, -1));
            Console.WriteLine(v.TotalProducts(5, 7, 8, 2));
            Console.WriteLine();
        }
    }
}
