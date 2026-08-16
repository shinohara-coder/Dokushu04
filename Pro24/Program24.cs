using System.Globalization;

namespace Pro24
{
    internal class IteratorBasic
    {
        static void Printset<T>(HashSet<T> set)
        {
            Console.WriteLine(String.Join(",", set.ToArray()));
        }
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 10, 15, 20, 30 };
            hs.IntersectWith(new HashSet<int>() { 1, 10, 20, 30, 60 });
            Printset(hs);

            hs.ExceptWith(new HashSet<int> { 15, 30 });
            Printset(hs);
        }
    }
}
