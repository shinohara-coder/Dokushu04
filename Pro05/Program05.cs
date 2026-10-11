using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{

    internal class LambdaCapture
    {
        static void PrintList<T>(LinkedList<T> list)
        {
            WriteLine(String.Join(",", list.ToArray()));
        }
        static void Main(string[] args)
        {
            var animals = new[] { "とら", "うさぎ", "たつ" };
            var list = new LinkedList<string>(animals);

            WriteLine(list.Count);
            WriteLine(list.Contains("とら"));

            list.AddFirst("ねずみ");
            list.AddLast("いのしし");
            list.AddBefore(list.Last, "いぬ");
            list.AddAfter(list.First, "うし");
            PrintList(list);

            list.Remove("たつ");
            list.RemoveLast();
            PrintList(list);

            var node = list.First;
            list.Remove(node);
            list.AddLast(node);
            PrintList(list);
        }
    }
}

