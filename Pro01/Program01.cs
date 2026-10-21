using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PassRefBasic
    {
        internal int CountUp(ref int data)
        {
            data++;
            return data;
        }
        static void Main(string[] args)
        {
            var data = 1;
            var p = new PassRefBasic();
            WriteLine(p.CountUp(ref data));
            //WriteLine(p.CountUp(data));
            WriteLine(data);
        }
    }
}


