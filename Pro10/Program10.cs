using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro10
{
    interface IHoge
    {
        void Foo(string str);
    }

    interface IHoge2
    {
        void Foo(string str2);
    }

    internal class MyClass : IHoge, IHoge2
    {
        public MyClass() { }

        public void Foo(string str)
        {
            WriteLine($"暗黙的 = {str}");
        }

        void IHoge.Foo(string str)
        {
            WriteLine($"IHoge.Foo = {str}");
        }

        void IHoge2.Foo(string str)
        {
            WriteLine($"IHoge2.Foo = {str}");
        }
    }

    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            mc.Foo("い");

            var ih = (IHoge)mc;
            ih.Foo("ろ");

            var ih2 = (IHoge2)mc;
            ih2.Foo("は");
        }
    }
}