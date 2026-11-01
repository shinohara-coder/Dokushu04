using System.IO.Pipes;
using static System.Console;

namespace Pro22
{
    internal class MyParent
    {
        public MyParent(string childName)
        {
            WriteLine($"{childName}の親です。");
        }

        public MyParent() { }
    }

    internal class MyChild : MyParent
    {
        public MyChild(string childName)
        {
            WriteLine($"子の{childName}です。");
        }
    }

    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var c = new MyChild("太郎");
        }
    }
}
