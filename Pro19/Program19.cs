namespace Pro19
{
    
    internal class DelegateAnonymous
    {
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }
        static void Main(string[] args)
        {
            var data = new[] { "あいうえお", "かきくけこ", "さしすせそ", "たちつてと" };
            var dm = new DelegateAnonymous();
            dm.ArrayWalk(data, delegate (string d)
            {
                return $" [{d}] ";
            });
        }

    }
}
