using IronPython.Runtime;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 20, 30, 60, 10, 15 };
            hs.Add(10);
            hs.Add(5);
            hs.Remove(60);

            foreach (var v in hs)
            {
                WriteLine(v);
            }

            WriteLine(hs.Count);
        }
    }
}
