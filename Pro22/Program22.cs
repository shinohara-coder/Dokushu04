namespace Pro22
{
    struct Coodinate
    {
        public double X;
        public double Y;

        public Coodinate(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    
    internal class IteratorBasic
    {
        public static void Show(in Coodinate c)
        {
            Console.WriteLine($"{c.X }, {c.Y}");
            //c.X = 10;
        }
        static void Main(string[] args)
        {
            Show(new Coodinate(10, 15));
        }
    }
}
