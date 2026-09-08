using static System.Console;

namespace Pro16
{
    internal struct MutableValue
    {
        public string Name { get; set; }

        public MutableValue()
        {
            this.Name = "名無権兵衛";
        }

        public void Update(string name)
        {
            this.Name = name;
            WriteLine("Update method is finished!!");
        }
    }

    internal class DelegeteUse
    {
        static readonly MutableValue mv = new();
        static void Main(string[] args)
        {
            //mv.Name = "佐藤リオ";
            mv.Update("松本大洋");
            WriteLine(mv.Name);
        }
    }
}
