using System.Numerics;
using static System.Console;

namespace SelfCSharp.Chap02
{
    internal class PassRefArray
    {
        public int[] Update(ref int[] data)
        {
            data[0] = 5;

            data = new[] { 10, 20, 30 };
            return data;
        }
        static void Main(string[] args)
        {
            var data = new[] { 2, 4, 6 };
            var p = new PassRefArray();
            WriteLine(p.Update(ref data)[0]);
            //WriteLine(p.Update(data)[0]);
            WriteLine(data[0]);
        }
    }
}


