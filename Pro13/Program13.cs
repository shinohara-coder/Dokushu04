global using static System.Console;

namespace Pro13
{
    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            //var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            //WriteLine(list.FindIndex(v => v < 0));
            //WriteLine(list.FindLastIndex(v => v < 0));
            //WriteLine(list.FindIndex(2, 3, v => v < 0));

            List<string> list = new List<string> { "からすなぜ鳴くの", "からすは山に",
                 "可愛い七つの", "子があるからよ" };
            var result = list.ConvertAll(str => str.Substring(0, 5));
        }
    }
}
