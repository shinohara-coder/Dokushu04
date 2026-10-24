using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PassRefReturn
    {
        public ref int RetrunRef(int[] data)
        {
            return ref data[0];
        }
        static void Main(string[] args)
        {
            var data = new[] { 1, 2, 3 };
            var p = new PassRefReturn();
            ref int num = ref p.RetrunRef(data);

            num = 10;
            WriteLine(num);
            WriteLine(data[0]);
        }
    }
}

