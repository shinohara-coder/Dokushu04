namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        //internal class StringLengthComparer : IComparer<string>
        //{
        //    public int Compare(string? x, string? y)
        //    {
        //        return x.Length - y.Length;
        //        //return y.Length - x.Length;
        //    }
        //}
        static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "バラ",
                "ひまわり",
                "あざみ",
                "チューリップ"
            };

            list.Sort((x, y) => x.Length - y.Length);
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}

