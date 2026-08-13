using System.Text.RegularExpressions;

namespace Pro15
{
    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var str = "にわに3わうらにわに51わにわとりがいる";
            var rgx = new Regex(@"\d{1,}わ");
            var result = rgx.Split(str);
            foreach (var s in result)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}