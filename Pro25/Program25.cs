namespace Pro25.hoge
{
    internal partial class TupleBasic
    {   
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
        }
        static void Main(string[] args)
        {
            var a = new TupleBasic();
            var t = a.GetMaxMin(100, 250);
            Console.WriteLine($"{nameof(t.max)}:{t.max}\n{nameof(t.min)}:{t.min}");

            var (outMax, outMin) = a.GetMaxMin(58, 26);
            Console.WriteLine($"{nameof(outMax)}:{outMax}\n{nameof(outMin)}:{outMin}");
        } 
    }
}
