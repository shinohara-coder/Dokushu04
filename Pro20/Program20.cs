using static System.Console;

namespace Pro20
{
    internal class PassRefArray
    {
        static void Main(string[] args)
        {
            //object obj = 123;
            //object obj = "123456789";
            object obj = new string[] { };
            WriteLine(obj switch
            {
                int i when i >= 15 => "15以上の数値です。",
                int i => "数値です。",
                string str when str.Length < 10 => "10文字未満の文字列です。",
                string str => "文字列です。",
                _ => "意図しない値です。"
            });
        }
    }
}
