using IronPython.Hosting;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pro10
{
    internal class PythonCall
    {
        
        static void Main(string[] args)
        {
            var py = Python.CreateRuntime();
            dynamic script = py.UseFile("C:\\Users\\hirok\\source\\repos\\Dokushu04\\Pro11\\myClass.py");
            dynamic clazz = script.MyClass();
            Console.WriteLine(clazz.greet("山田"));
        }
    }

}
