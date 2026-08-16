namespace Pro25.hoge
{
    internal partial class MyPartialMethod
    {   
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお",
                ["Tulip"] = "チューリップ"
            };

            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key} : {m.Value}");
            }
        }
    }
}
