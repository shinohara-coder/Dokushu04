using System.Text.RegularExpressions;

namespace Pro08
{
    internal class Pet
    {
        public string Name { get; init; }
        public Pet(string name = "")
        {
            this.Name = name;
        }
    }

    internal class MySingleton
    {   
        static void Main(string[] args)
        {
            var p1 = new Pet("タロウ");
            Console.WriteLine(p1.Name);

            var p2 = new Pet
            {
                Name = "花子"
            };
            Console.WriteLine(p2.Name);

            //p2.Name = "タロウ";
        }
    }
}

