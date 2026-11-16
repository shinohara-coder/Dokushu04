global using static System.Console;

namespace Pro14
{
    internal class DelegeteUseCounter
    {
        static void Main(string[] args)
        {
            var mc = new MyPartial("一郎", "板垣");
            WriteLine(mc.Show());
            WriteLine(mc.Greet());
        }
    }
}
