using IronPython.Hosting;
using static System.Console;

namespace Pro12
{    
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var py = Python.CreateRuntime();
            dynamic script = py.UseFile(@"C:\Users\hirok\source\repos\Dokushu04\Pro11\myClass.py");
            dynamic clazz = script.MyClass();
            WriteLine(clazz.greet("田中"));
        }
    }
}

