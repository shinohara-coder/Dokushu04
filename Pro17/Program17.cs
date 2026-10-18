using System.Text.RegularExpressions;
using static System.Console;

namespace Pro17
{
    internal class MyApp
    {
        public static readonly string Title = "独習C#";
    }

    internal class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            WriteLine(MyApp.Title);
            //MyApp.Title = "hoge";
        }
    }
}
