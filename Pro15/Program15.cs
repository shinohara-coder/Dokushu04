using System.Text.RegularExpressions;
using static System.Console;

namespace Pro15
{
    internal partial class MyPartialMethod
    {
        static partial void Log();
        static void Main(string[] args)
        {
            Log();
        }
    }

    //internal partial class MyPartialMethod
    //{
    //    static partial void Log()
    //    {
    //        WriteLine("ログを記録しました。");
    //    }
    //}

    //internal class DelegeteMulti
    //{
    //    static void Main(string[] args)
    //    {
            
    //    }
    //}
}