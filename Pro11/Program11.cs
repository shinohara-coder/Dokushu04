using IronPython.Hosting;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class ArgParams
    {
        static void Main(string[] arngs)
        {
            try
            {
                using (var sr = new StreamReader(@"C:\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                throw;
            }
        }
    }

}
