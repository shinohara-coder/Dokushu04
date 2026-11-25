global using static System.Console;

namespace Pro10
{
    internal class MyAppExceptionClient
    {
        internal static Action CreateAction(int init)
        {
            int value = init;
            return () =>
            {
                value++;
                WriteLine(value);
            };
        }
        
        static void Main(string[] args)
        {
            Action show = CreateAction(10);
            show();
            show();
            show();
        }
    }
}