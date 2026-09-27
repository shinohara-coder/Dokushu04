using static System.Console;

namespace Pro16
{
    internal class DelegeteMultiResult
    {
        static void Main(string[] args)
        {
            string? value = null;
            if (value == null)
            {
                value = default;
            }
            WriteLine(value);
        }
    }
}
