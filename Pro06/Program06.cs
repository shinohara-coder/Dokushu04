using Pro06.Extension;
using static System.Console;

namespace Pro06
{
    internal class AsyncStream
    {
        static void Main(string[] args)
        {
            //10.Times(() => WriteLine("Hello! world!"));

            //var targetDate = new DateTime(2026, 11, 2, 12, 45, 56);

            //if (targetDate.IsToday())
            //{
            //    WriteLine("今日届いたデータです。");
            //}
            //else
            //{
            //    WriteLine("今日届いたデータではありません。");
            //}

            var longTitle = "C#の拡張メソッドについて分かり易い解説記事";
            WriteLine(longTitle.Truncate(10));
        }
    }
}
