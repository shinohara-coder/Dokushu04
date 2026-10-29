using System.Text.RegularExpressions;
using static System.Console;

namespace Pro15
{
    internal class Pet
    {
        //public string Name { get; init; } = "";
        public string Name { get; } = "";

        public Pet(string name = "")
        {
            this.Name = name;
        }
    }

    internal class DelegeteMulti
    {
        static void Main(string[] args)
        {
            var p1 = new Pet("タロウ");
            WriteLine(p1.Name);

            //var p2 = new Pet
            //{
            //    Name = "トラ"
            //};
            //WriteLine(p2.Name);
            //p1.Name = "悪魔";
        }
    }
}