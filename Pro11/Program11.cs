using System.Collections;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro12
{
    public interface IHoge
    {
        void Log(string msg)
        {
            WriteLine($"Log: {msg}");
        }
    }

    public class Hoge : IHoge { }

    internal class ScopeBasic
    {

        static void Main(string[] args)
        {
            
        }
    }
}

