global using static System.Console;

namespace Pro12
{
    internal record Animal(string Name);
    internal record Hamster(string Name, string Type) : Animal(Name);
    
    internal class ScopeBasic
    {
        static void Main(string[] args)
        {
            Animal a = new Hamster("まめ", "ブルーサファイア");
            Animal a2 = (Hamster)a with { Type = "スノーホワイト" };
            WriteLine(a2);
        }
    }
}

