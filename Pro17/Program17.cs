using static System.Console;
using Chapter = Pro17.Other;

namespace Pro17.Ns
{ 
    internal class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            var ci = new Chapter::CultureInfo("ja-JP");
        }
    }

    internal class Chapter { }
}
