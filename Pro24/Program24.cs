#define DEBUG
using static System.Console;

namespace Pro24
{
    internal class PassOut
    {
        static void Main(string[] args)
        {
#if DEBUG
            WriteLine("デバッグ時にだけ表示します。");
#endif
        }
       
    }
}
