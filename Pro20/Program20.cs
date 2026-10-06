using System.Globalization;
using static System.Console;

namespace Pro20
{
    internal class PassRefArray
    {
        static void Main(string[] args)
        {
            //var dt = new DateTime(2026, 10, 06, 21, 49, 40);
            //var cul = new CultureInfo("ja-JP");
            //cul.DateTimeFormat.Calendar = new JapaneseCalendar();
            //WriteLine(dt.ToString("ggyy年MM月dd日 (dddd) HH:mm:ss", cul));
            //var span = new TimeSpan(100, 15, 30, 52);
            //WriteLine(dt.Add(span));

            //var dt1 = new DateTime(2022, 02, 15, 13, 17, 23, 123);
            //var dt2 = new DateTime(2013, 08, 05, 05, 15, 10, 456);
            //var span = new TimeSpan(3, 15, 30, 45, 789);
            //WriteLine(dt1 + span);
            //WriteLine(dt1 - span);
            //WriteLine(dt1 == dt2);
            //WriteLine(dt1 >= dt2);

            DateTime dt = default;
            DateTime.TryParse("2022/02/15 13:17:23", out dt);
            WriteLine($"{dt.Hour}時{dt.Minute}分{dt.Second}秒");

            WriteLine(DateTime.Now.AddDays(15));
        }
    }
}
