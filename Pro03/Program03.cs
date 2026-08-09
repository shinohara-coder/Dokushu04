using System.ComponentModel;

namespace SelfCSharp.Chap09.Priority1
{
    internal class MyStruct
    {

    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            object obj = true;
            switch (obj)
            {
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;
                case string str:
                    Console.WriteLine(str[0]);
                    break;
                case bool b:
                    Console.WriteLine(b ? "trueです。" : "falseです。");
                    break;
                default:
                    Console.WriteLine("意図しない型です。");
                    break;
            }
        }
    }
}

