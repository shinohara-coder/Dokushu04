using System.Text.RegularExpressions;
using static System.Console;

namespace Pro12
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var msg = "Local Variable";

            void MyLocal()
            {
                var msg = "Inner Variable";
                WriteLine(msg);
            }
            MyLocal();
            WriteLine(msg);
        }
    }
}

