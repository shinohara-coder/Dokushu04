using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro08
{
    internal class IteratorBasic
    {
        public IEnumerable<string> GetStrings()
        {
            yield return "あいうえお";
            yield return "かきくけこ";
            yield return "さしすせそ";
        }
        static void Main(string[] args)
        {
            var ite = new IteratorBasic();
            var itrObj = ite.GetStrings();
            foreach(var str in itrObj)
            {
                WriteLine(str);
            }
        }
    }
}

