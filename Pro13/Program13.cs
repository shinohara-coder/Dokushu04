global using static System.Console;

namespace Pro13
{
    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            list.RemoveAll(v => v < 0);
            list.ForEach(v => WriteLine(v));

            //WriteLine(list.FindIndex(v => v < 0));
            //WriteLine(list.FindLastIndex(v => v < 0));
            //WriteLine(list.FindIndex(2, 3, v => v < 0));

            //List<string> list = new List<string> { "からすなぜ鳴くの", "からすは山に",
            //     "可愛い七つの", "子があるからよ" };
            //var result = list.ConvertAll(str => str.Substring(0, 5));
            //result.ForEach(str => WriteLine(str));

            //WriteLine(list.Exists(str => str.Length >= 7));
            //list.ForEach(str => WriteLine(str.Length));
            //WriteLine(list.TrueForAll(str => str.Length < 10));
        }
    }
}
