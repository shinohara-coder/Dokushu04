namespace Pro14
{
    internal class DelegeteNoUse
    {
        void ArrayWalk(string[] data)
        {
            foreach (var value in data)
            {
                Console.WriteLine($"[{value}]");
            }
        }
        static void Main(string[] args)
        {
            var data = new[] { "あいうえお", "かきくけこ", "さしすせそ", "たちつてと" };
            var nu = new DelegeteNoUse();
            nu.ArrayWalk(data);
        }
    }
}
