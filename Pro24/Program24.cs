using static System.Console;

namespace Pro24
{
    internal class PassBasic
    {
        public int CountUp(int data)
        {
            data++;
            return data;
        }
        static void Main(string[] args)
        {
            var data = 1;
            var p = new PassBasic();
            WriteLine(p.CountUp(data));
            WriteLine(data);
        }
    }
}
