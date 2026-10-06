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

            var dt1 = new DateTime(2022, 02, 15, 13, 17, 23,123);
            var dt2 = new DateTime(2013, 08, 05, 05, 15, 10,456);
            var sub = dt1.Subtract(dt2);
            WriteLine(sub);
            WriteLine(sub.ToString("c"));
            WriteLine(sub.ToString("G"));
            WriteLine(sub.ToString(@"d\.h\.m\:s"));
        }
    }
}
