using System.Globalization;

namespace Pro18
{
    internal class DelegateMultiResult
    {
        static void Main(string[] args)
        {
            #region 練習01
            //DateTime dt = default;
            //Console.WriteLine(dt);
            //if (DateTime.TryParse("2026/8/13 19:31:54", out dt))
            //{
            //    Console.WriteLine(dt);
            //}
            //else
            //{
            //    Console.WriteLine("日付に変換出来ませんでした。");
            //}
            #endregion

            var dt1 = DateTime.Now;
            //var dt2 = new DateTime(2017, 5, 18, 15, 28, 23);
            var dt2 = new DateTime(1974, 6, 2, 7, 28, 23);
            var sub = dt1.Subtract(dt2);
            Console.WriteLine(sub.ToString("c"));
            Console.WriteLine(sub.ToString(@"d\.hh\:mm\:ss"));
        }
    }
}
