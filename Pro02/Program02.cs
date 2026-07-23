namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "からすなぜ鳴くの", "からすは山に",
                 "可愛い七つの", "子があるからよ"};
            var result = list.FindAll(str => str.StartsWith("からす"));

            result.ForEach(s => Console.WriteLine(s));
        }
    }
}

