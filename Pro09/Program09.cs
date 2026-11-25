global using static System.Console;

namespace Pro08
{
    internal record Person(string FirstName, string LastName, int Age);

    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var msg = "鈴木大地";
            Action show = () => { WriteLine(msg); };
            Action<string> hoge = str => { WriteLine(str); };
            show();
            hoge("こんにちは！");
        }
    }
}

