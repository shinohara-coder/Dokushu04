using IronPython.Hosting;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class ArgParams
    {
        public int TotalProducts(int initial, params int[] values)
        {
            int result = 1;
            foreach (var value in values)
            {
                result *= value;
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            var v = new ArgParams();
            Console.WriteLine(v.TotalProducts(12, 15, -1, 10));
            Console.WriteLine(v.TotalProducts(5, 7, 8, 2, 2, 5));
            func(v.TotalProducts(100));
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }

}
