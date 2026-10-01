using static System.Console;

namespace SelfCSharp.Chap02
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            //var str = "WINGS2号";
            //WriteLine(str.Any(ch => Char.IsDigit(ch)));

            //var path = @"C:\Learning_Programming\Oracle_study\Docker_Oracle.sql";
            //WriteLine(path.Substring(path.LastIndexOf(".") + 1));

            var str4 = "うめ,もも,さくら,あんず";
            var result4 = str4.Split(',', 2);
            foreach(var s in result4)
            {
                WriteLine(s);
            }
        }
    }
}


