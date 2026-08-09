using System.Text;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            //string str1 = "あいう";
            //string str2 = "あいう";
            var str1 = new StringBuilder("あいう");
            var str2 = new StringBuilder("あいう");
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1 == str2);
            Console.WriteLine(object.ReferenceEquals(str1, str1));
        }
    }
}

