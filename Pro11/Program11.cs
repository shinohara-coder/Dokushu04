global using static System.Console;

namespace Pro12
{
    internal class LambdaMember
    {
        private int _value;

        public LambdaMember() => WriteLine("constructor");

        public LambdaMember(int value) => this._value = value;

        public int Value
        {
            get => this._value;
            set => this._value = value;
        }

        public DateTime Current => DateTime.Now;

        public int this[int index] => this.Value * index;

        public int Calculate() => this.Value * this.Value;

        public static bool operator true(LambdaMember e) => e.Value == 0;
        public static bool operator false(LambdaMember e) => e.Value != 0;

        static void Main(string[] args)
        {
            var lm = new LambdaMember(2);

            WriteLine(lm.Current);
            WriteLine(lm[3]);
            WriteLine(lm.Calculate());

            if (lm)
            {
                WriteLine($"{nameof(lm)}の値は真");
            }
            else
            {
                WriteLine($"{nameof(lm)}の値は偽");
            }
        }
    }
}

