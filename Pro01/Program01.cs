using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PassRefBasic
    {
        static void Main(string[] args)
        {
            //object obj = 'a';
            object obj = "abcdefg";

            WriteLine(obj switch
            {
                int i => $"数値です：{i}",
                string str => $"文字列です：{str}",
                var data => $"その他の方でした：{data}"
            });
        }
    }
}


