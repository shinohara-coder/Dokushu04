using static System.Console;

namespace Pro08
{
    internal class DelegateAnonymous
    {
        internal void ArrayWalk(string[] data,Func<string,string> output)
        {
            foreach(var value in data)
            {
                WriteLine(output(value));
            }
        }
        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegateAnonymous();
            //dm.ArrayWalk(data, delegate (string d)
            //{
            //    return $" [{d}] ";
            //});

            dm.ArrayWalk(data, d => $" [{d}] ");
        }
    }
}
