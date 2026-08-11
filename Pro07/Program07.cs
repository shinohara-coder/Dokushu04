//#define DEBUG
using System.Globalization;

namespace Pro07
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Format("名前は{0,-10}です。", "サクラ"));
            Console.WriteLine(string.Format("カスタム(0補完):{0:0,000.0000}", 1234.56));
            Console.WriteLine(string.Format("カスタム(補完無):{0:#,###.####}", 1234.56));
            Console.WriteLine(string.Format("カスタム(複合):{0,20:0,000.000000}", 1234.56));
        }
    }
}
