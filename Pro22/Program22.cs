namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            int factor = 2;

            //Func<double, double> func = static x => x * factor;
            Func<double, double> func = x => x * factor;
            Console.WriteLine(func(16));
        }
    }
}
