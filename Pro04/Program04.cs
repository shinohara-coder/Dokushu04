namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            double Discount(int price, double rate)
            {
                return price * (1 - rate);
            }

            Console.WriteLine(Discount(10000, 0.3));
        }
    }
}

