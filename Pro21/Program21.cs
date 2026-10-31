using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro21
{ 
    internal class LambdaMember
    {
        internal class MyParent
        {
            public MyParent()
            {
                WriteLine("親です。");
            }
        }

        internal class MyChild : MyParent
        {
            public MyChild()
            {
                WriteLine("子です。");
            }
        }

        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}
