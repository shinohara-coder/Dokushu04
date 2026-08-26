namespace Pro06
{   
    internal class Practice4
    {
        static int Increment(int value)
        {
            value += 5;
            return value;
        }
        static void Main(string[] args)
        {
            int value = 10;
            //Console.WriteLine(Increment(ref value));
            Console.WriteLine(Increment(value));
            Console.WriteLine(value);
        }
    }   
}
