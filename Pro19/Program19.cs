using static System.Console;

namespace Pro19
{
    internal class PassArray
    {
        static void Main(string[] args)
        {
            //object obj = 123;
            object obj = "123456789";
            //object obj = new string[] { };
            switch (obj)
            {
                case int i when i >= 15:
                    WriteLine("15以上の数値です。");
                    break;
                case int i:
                    WriteLine("数値です。");
                    break;
                case string str when str.Length < 10:
                    WriteLine("10文字未満の文字列です。");
                    break;
                case string str:
                    WriteLine("文字列です。");
                    break;
                default:
                    WriteLine("意図しない値です。");
                    break;
            }
        }
    }

}
