using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            //WriteLine(string.Format("{0:d8}", 12345));
            //WriteLine(string.Format("{0:e7}", 12345));
            //WriteLine(string.Format("{0:E7}", 12345));
            //WriteLine(string.Format(new CultureInfo("da-DK"), "{0:C}", 12345));
            //WriteLine(string.Format("{0:0,000.00000}", 1234.56));
            //WriteLine(string.Format("{0:#,###.####}", 1234.56789));
            //WriteLine(string.Format("{0,100:0,000.00000000}", 1234.56789));
            //WriteLine(string.Format("日付：{0:F}", DateTime.Now));
            //var price = 9980;
            //WriteLine($"{price:c}");

            WriteLine("プログラミング".Substring(4,3));
            var str = "鈴木\t太郎\t男\t50歳\t広島県";
            var strArray = str.Split('\t');
            foreach(var s in strArray)
            {
                WriteLine(s);
            }
        }
    }
}

