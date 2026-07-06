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
            //var str = "田中一郎";
            string? str = null;
            Console.WriteLine(str ?? throw new Exception("変数strがnullです。"));
        }
    }

}
