using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro14
{
    internal class Hoge
    {
        public string value = "field";

        public Hoge() { }

        public Hoge(string value)
        {
            this.value = value;
        }
    }
    internal class DelegeteUseCounter
    {
        static void Main(string[] args)
        {
            //var h = new Hoge("coustructor") { value = "initializer" };
            //var h = new Hoge("coustructor");
            var h = new Hoge();
            WriteLine(h.value);
        }
    }
}
