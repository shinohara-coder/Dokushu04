using static System.Console;

namespace Pro18
{
    internal class NameOfNull
    {
        public void Hoge(string? sss)
        {
            if (sss == null)
            {
                throw new ArgumentNullException(nameof(sss));
            }
        }
        static void Main(string[] args)
        {
            var mc = new NameOfNull();
            mc.Hoge(null);
        }
    }
}
