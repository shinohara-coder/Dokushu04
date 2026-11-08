using static System.Console;

namespace Pro14
{
    internal class MyClass
    {
        protected double value;

        public MyClass(double value)
        {
            this.value = value;
        }

        public virtual string GetValue()
        {
            return this.value.ToString("F1");
        }
    }

    internal class MySubClass : MyClass
    {
        public MySubClass(double value) : base(value) { }

        public override string GetValue()
        {
            return $"[{base.GetValue()}]";
        }
    }
    internal class DelegeteUseCounter
    {
        static void Main(string[] args)
        {
            var msc = new MySubClass(12.56);
            WriteLine(msc.GetValue());
        }
    }
}
