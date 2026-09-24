//#define DEBUG
//#undef DEBUG
using System.Diagnostics;
using static System.Console;

namespace Pro08
{
    internal class TryCatchOrder
    {
        [Conditional("DEBUG")]
        static void Message()
        {
            WriteLine("デバッグ時にだけ表示します。");
        }
        static void Main(string[] args)
        {
            Message();
            WriteLine("終了しました。");
        }
    }
}
