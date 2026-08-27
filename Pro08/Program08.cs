using System.Runtime.CompilerServices;

namespace Pro08
{   
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "一郎",
                LastName = "田中"
            };

            Console.WriteLine(p.Show());
        }
    }
}
