global using static System.Console;

namespace SelfCSharp.Chap02
{
    internal class PassRefArray
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    var m = double.MaxValue;
                    var n = double.Epsilon;
                    WriteLine(m * m);
                    WriteLine(n * n);
                }
            }
            catch (OverflowException ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}


