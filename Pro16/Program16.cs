using static System.Console;

namespace Pro16
{
    internal class DelegeteMultiResult
    {
        static void Main(string[] args)
        {
            string? value = "こんにちは";
            WriteLine(value == null ? "規定値" : value);
            value = null;
            WriteLine(value ?? "規定値");
        }
    }
}
