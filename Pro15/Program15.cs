using System.Text.RegularExpressions;

namespace Pro15
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
    internal class DelegeteUse
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                lastName = "田中",
                firstName = "一郎"
            };
            p.Show();
            p.Show("殿");
            p.Show("様");
            //p.Show("初めまして", "様");
        }
    }
}