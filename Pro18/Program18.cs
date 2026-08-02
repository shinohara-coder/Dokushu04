using System.Diagnostics;

namespace Pro18
{
    internal class DelegateMultiResult
    {
        [Conditional("DEBUG")]
        static void Message()
        {
            Console.WriteLine("デバッグ時にだけ表示します。");
        }

        static void Main(string[] args)
        {
            Message();
            Console.WriteLine("終了しました。");
        }
    }
}
