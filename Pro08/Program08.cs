using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro08
{
    internal class TryCatchOrder
    {
        static void Main(string[] args)
        {
            //(double x, double y) t1 = (10, 30);
            //(double a, double b) t2 = (10, 30);
            //(double x, (double y, double z)) t3 = (10, (20, 30));

            //WriteLine(t1 == (10, 30));
            //WriteLine(t1 != (10, 30));
            //WriteLine(t1 == t2);
            //WriteLine(t3 == (10, (20, 30)));
            ////Console.WriteLine(t1 == t3);

            //WriteLine(t1.x == 10 && t1.y == 30);
            //WriteLine(t1.x != 10 || t1.y != 30);

            //var t = (13, 108);
            //WriteLine(t.Item1);
            //WriteLine(t.Item2);

            var info = new { Title = "独習C#", Price = 1000 };
            WriteLine(info.Title);
            WriteLine(info.Price);
        }
    }
}
