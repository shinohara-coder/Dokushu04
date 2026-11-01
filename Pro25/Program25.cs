using System.Globalization;
using static System.Console;

namespace Pro25
{
    internal partial class PassArray
    {
        static void Main(string[] args)
        {
            //object obj = 123;
            //object obj = "123";
            object obj = 458;

            WriteLine(obj switch
            {
                123 => "123です。",
                int i => "数値です。",
                string s => "文字列型です。",
                _ => "意図しない値です。"
            });
        }
    }
}
