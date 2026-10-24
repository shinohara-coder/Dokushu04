using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PassOut
    {
        public void GetMaxMin(int x, int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }

        static void Main(string[] args)
        {
            var a = new PassOut();
            a.GetMaxMin(5, 3, out int resultMax, out int resutlMin);
            WriteLine(resultMax);
            WriteLine(resutlMin);
        }
    }
}

