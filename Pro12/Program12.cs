global using static System.Console;

namespace Pro12
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "からすなぜ鳴くの", "からすは山に",
                 "可愛い七つの", "子があるからよ" };
            //var result = list.ConvertAll(str => str.Substring(0, 5));
            //result.ForEach(str => WriteLine(str));

            //var result = list.Find(str => str.StartsWith("からす"));
            //WriteLine(result);

            var result = list.FindAll(str => str.StartsWith("からす"));
            result.ForEach(str => WriteLine(str));
        }
    }
}

