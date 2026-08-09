namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            object obj = false;
            Console.WriteLine(obj switch
            {
                int i when i >= 15 => "15以上の数値です。",
                int i => "数値です。",
                string str when str.Length < 10 => "10文字未満の文字列です。",
                string str => "文字列です。",
                bool b => b ? "trueです。" : "falseです。",
                _ => "意図しない型です。"
            });
        }
    }
}

