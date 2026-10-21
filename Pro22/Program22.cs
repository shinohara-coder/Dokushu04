using static System.Console;

namespace Pro22
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";

        public void Show(string greeting = "こんにちは", string title = "さん")
        {
            WriteLine($"{greeting}、{this.lastName}{this.firstName}{title}");
        }
    }

    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var p = new Person
            { lastName = "田中", firstName = "一郎" };
            p.Show();
            p.Show("はじめまして", "殿");
            p.Show(title: "師", greeting:"やあ！");
        }
    }
}
