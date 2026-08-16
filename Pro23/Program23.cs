namespace Pro23
{
    internal class LambdaMember
    {
        static void Main(string[] args)
        {
            var flower = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお",
                ["Turip"] = "チューリップ",
            };

            var enu = flower.GetEnumerator();
            while (enu.MoveNext())
            {
                Console.WriteLine(enu.Current.ToString());
            }
        }
    }
}
