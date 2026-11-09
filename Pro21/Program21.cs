using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro21
{
    internal class LambdaMember
    {
        static void Main(string[] args)
        {
            var data = new[] { "C#", "Java", "Python" };
            try
            {
                var i = 0;
                while (true)
                {
                    WriteLine(data[i++]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                WriteLine(ex.Data);
                WriteLine(ex.Message);
            }
        }
    }
}
