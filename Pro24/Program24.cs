using System.Globalization;

namespace Pro24
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            int? num = 108;
            string varName = nameof(num);
            //Console.WriteLine(num.HasValue);
            //Console.WriteLine(num.Value);
            if (num.HasValue)
            {
                int i = num.Value;
                Console.WriteLine($"変数：{varName}の値は{i}です。");
            }
            else
            {
                Console.WriteLine($"変数：{varName}は値を持ちません。");
            }
        }
    }
}
