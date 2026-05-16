using System;
using System.Runtime.Serialization;

namespace Pro04.hoge
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "からすなぜ鳴くの", "からすは山に", "可愛い七つの", "子があるからよ" };
            Console.WriteLine(list.Exists(str => str.Length >= 9));
        }
    }

}
