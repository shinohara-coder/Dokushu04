using System.Net;

namespace Pro10
{
    internal class AttrBasic
    {
        internal class Person
        {
            public string firstName = "";
            public string lastName = "";

            public void Show(string greeting = "こんにちは", string title = "さん")
            {
                Console.WriteLine($"{greeting}、{this.lastName}{this.firstName}{title}！");
            }
        }
        
        static void Main(string[] args)
        {
            var p = new Person
            {
                lastName = "田中",
                firstName = "三郎"
            };

            p.Show();
            p.Show(title: "氏", greeting: "こんばんは");
            //p.Show("氏", greeting: "こんばんは");
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
