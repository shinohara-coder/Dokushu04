using static System.Console;

namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            //var list = new List<string> { "からすなぜ鳴くの", "からすは山に",
            //     "可愛い七つの", "子があるからよ" ,"からすは飛んだ"};
            //var reslut = list.FindAll(str => str.StartsWith("からす"));
            //reslut.ForEach(s => WriteLine(s));

            var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            list.RemoveAll(v => v < 0);
            list.ForEach(v => WriteLine(v));
        }
    }
}
