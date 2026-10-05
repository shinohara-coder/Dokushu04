using System.Globalization;
using static System.Console;

namespace Pro19
{
    internal class PassArray
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2026, 10, 06, 08, 36, 38);
            var culture = new CultureInfo("ja-JP");
            //WriteLine($"{dt.Year}年{dt.Month}月{dt.Day}日 {dt.DayOfWeek} {dt.Hour}時{dt.Minute}分{dt.Second}秒{dt.Millisecond}ミリ秒");
            //WriteLine($"経過時間:{dt.Ticks} 年初から{dt.DayOfYear}日目");

            //WriteLine(dt.ToString());
            //WriteLine(dt.ToString("f"));
            //WriteLine(dt.ToString("F"));
            //WriteLine(dt.ToString("yyyy/MM/dd (dddd) HH:mm:ss"));
            WriteLine(dt.ToLongDateString());
            WriteLine(dt.ToLongTimeString());
        }
    }
}
