namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            object obj = "栃木県下都賀郡";
            switch (obj)
            {
                case int i when i >= 15:
                    Console.WriteLine("15以上の数値です。");
                    break;
                case int i:
                    Console.WriteLine("数値です。");
                    break;
                case string str when str.Length < 10:
                    Console.WriteLine("10文字未満の文字列です。");
                    break;
                case string str:
                    Console.WriteLine("文字列です。");
                    break;
                default:
                    Console.WriteLine("意図しない型です。");
                    break;
            }
        }
    }
}

