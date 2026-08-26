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

        public string Show(string format)
        {
            return String.Format(format, this._name, this._age);
        }

    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            
        }
    }
}

