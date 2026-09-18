using static System.Console;

namespace Pro18
{
    internal class DelegateLambda
    {
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                WriteLine(output(value));
            }
        }
        static void Main(string[] args)
        {
            var data = new string[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dl = new DelegateLambda();
            dl.ArrayWalk(data, (string d) =>
                {
                    return $" [{d}] ";
                });
        }
    }
}
