using static System.Console;

namespace Pro24
{
    internal class PassOut
    {
        static void Main(string[] args)
        {
            var mc = new MyPartial
            {
                FirstName = "一郎",
                LastName = "田中"
            };

            WriteLine(mc.Show());
            WriteLine(mc.Greet());
        }
       
    }
}
