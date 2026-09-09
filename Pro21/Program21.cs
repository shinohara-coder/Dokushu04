using static System.Console;

namespace Pro21
{
    public record Animal(string Name);
    public record Hamster(string Name, string Type) : Animal(Name);
    
    internal class PassRefArray
    {
        static void Main(string[] args)
        {
            Animal a = new Hamster("まめ", "ブルーサファイア");
            Animal a2 = (Hamster)a with { Type = "スノーホワイト" };
            WriteLine(a2);
        }
    }
}
