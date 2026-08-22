namespace Pro17
{
    internal class PassArray
    {
        public int[] Update(int[] data)
        {
            data[0] = 5;
            return data;
        }
        static void Main(string[] args)
        {
            var data = new[] { 2, 4, 6 };
            var p = new PassArray();
            Console.WriteLine(p.Update(data)[0]);
            Console.WriteLine(data[0]);
        }
    }
}
