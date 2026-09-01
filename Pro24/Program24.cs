using Pro24.StringExtensions;
using System.Globalization;

namespace Pro24
{
    internal class PassOut
    {
        static void Main(string[] args)
        {
            //string longTitle = "C#の拡張メソッドについての超分かり易い解説記事";
            string longTitle = "";
            Console.WriteLine(longTitle.Truncate(10));
        }
       
    }
}
