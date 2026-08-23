using System.Globalization;

namespace Pro24
{
    internal class PassOut
    {
        public void GetMaxMin(int x, int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }
        static void Main(string[] args)
        {
            var a = new PassOut();
            int resultMax = 0;
            int resultMin = 0;
            a.GetMaxMin(5, 3, out resultMax, out resultMin);
            Console.WriteLine($"max:{resultMax}\nmin:{resultMin}");
        }
       
    }
}
