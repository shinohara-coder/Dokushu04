using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Person
    {
        private string firstName = "";
        private string lastName = "";
    }
    
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
        }
    }
}

