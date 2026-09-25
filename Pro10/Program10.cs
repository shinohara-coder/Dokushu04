using System.Runtime.Serialization;
using static System.Console;

namespace Pro10
{
    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            dynamic d = 10;
            d = "hoge";
            d.Hoge();
        }
    }
}