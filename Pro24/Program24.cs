using System.Globalization;

namespace Pro24
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 3, 6, 9 };
            //list.ForEach(v => Console.WriteLine(v * v));
            int result = 0;
            list.ForEach(v => result += v);
            Console.WriteLine(result);
        }
    }
}
