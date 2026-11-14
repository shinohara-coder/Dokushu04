global using static System.Console;

namespace Pro07
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

    internal class TupleBasic
    {
        static readonly MutableValue mv = new MutableValue();
        static void Main(string[] args)
        {
            mv.Update("田中武夫");
            WriteLine(mv.Name);
        }
    }
}
