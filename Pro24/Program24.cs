using System.Globalization;

namespace Pro24
{
    internal partial class MyPartial
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{LastName}{FirstName}です。";
        }
    }

    internal partial class MyPartial
    {
        public string Greet()
        {
            return $"こんにちは、{LastName}{FirstName}さん！";
        }
    }

    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var mc = new MyPartial
            {
                FirstName = "一郎",
                LastName = "小森田"
            };
            Console.WriteLine(mc.Show());
            Console.WriteLine(mc.Greet());
        }
    }
}
