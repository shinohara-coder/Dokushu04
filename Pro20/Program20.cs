using static System.Console;

namespace Pro20
{
    internal class PassRefArray
    {
        static Action CreateAction(int init)
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
            var show = CreateAction(10);
            show();
            show();
            show();
        }
    }
}
