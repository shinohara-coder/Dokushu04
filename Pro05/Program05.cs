namespace SelfCSharp.Chap09.Priority1
{
    internal class Hamster
    {
        private string _name = "";
        private int _age = 0;

        public Hamster(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public Hamster() : this("権兵衛", 0) { }

        public string Show(string format = "{0}は{1}歳です！")
        {
            return String.Format(format, this._name, this._age);
        }

    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var h1 = new Hamster("ハム太郎", 3);
            var h2 = new Hamster();
            Console.WriteLine(h1.Show("{1}歳の{0}でした！"));
            Console.WriteLine(h1.Show());
            Console.WriteLine(h2.Show());
            Console.WriteLine(h2.Show("{1}歳の{0}でした！"));
        }
    }
}

