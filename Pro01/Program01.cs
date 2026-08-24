using System.Diagnostics;
using System.Text;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        public static (double addition, double subtraction) AddSubtract(double x, double y)
        {
            return (x + y, x - y);
        }
        static void Main(string[] args)
        {
            double d1 = 3.14;
            double d2 = 1.73;
            //var t = AddSubtract(d1, d2);
            var (add, sub) = AddSubtract(d1, d2);
            Console.WriteLine($"{d1}と{d2}の和は[{add}]、差は[{sub}]です");
        }
    }
}


