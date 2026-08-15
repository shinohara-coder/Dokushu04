using System.Numerics;

namespace Pro23
{
    internal class LambdaMember
    {
        static void Main(string[] args)
        {
           var flower = new Dictionary<string, string>()
           {
               {"Rose", "バラ" },
               {"Sunflower", "ひまわり" },
               {"Morning Glory", "あさがお" },
               //{"Rose", "薔薇" }
           };

            Console.WriteLine(flower["Rose"]);
        }
    }
}
