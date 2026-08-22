using System.Runtime.CompilerServices;

namespace Pro19
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
            Console.WriteLine(p.CountUp(ref data));
            Console.WriteLine(data);
        }

    }
}
