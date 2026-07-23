namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "からすなぜ鳴くの", "からすは山に",
                 "可愛い七つの", "子があるからよ"};
            var result = list.Find(str => str.StartsWith("可愛い"));

            Console.WriteLine(result);
        }
    }
}


