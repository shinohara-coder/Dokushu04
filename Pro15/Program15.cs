using System.Text.RegularExpressions;
using static System.Console;

namespace Pro15
{
    interface IAnimal
    {
        string Name { get; set; }
        void Move();
    }

    internal class Hamster : IAnimal
    {
        public string Name { get; set; } = "";

        public void Move()
        {
            WriteLine($"{this.Name}は、トコトコ歩きます。");
        }
    }

    internal class DelegeteMulti
    {
        static void Main(string[] args)
        {
            IAnimal i = new Hamster()
            {
                Name = "サクラ"
            };

            i.Move();
        }
    }
}