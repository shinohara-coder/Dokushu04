using static System.Console;

namespace Pro23
{

    internal class ArgsParams
    {
        public int TotalProducts(int initial, params int[] values)
        {
            int result = initial;
            foreach (var value in values)
            {
                result *= value;
            }
            return result;
        }
        static void Main(string[] args)
        {
            var v = new ArgsParams();
            WriteLine(v.TotalProducts(3, -9, -6));
            WriteLine(v.TotalProducts(2, 8, 5, 6, 8, 9));
            WriteLine(v.TotalProducts(5, new[] { 2, -15, 3 }));
        }
    }
}

