using System;
using System.Runtime.Serialization;

namespace Pro04.hoge
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine($"{(int)name} : {name}");
            }
        }
    }

    internal enum Season { 
        Spring,
        Summer,
        Autum,
        Winter,
        All = Spring + Summer + Autum + Winter,
    }

}
