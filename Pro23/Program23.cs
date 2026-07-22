namespace Pro23
{
    internal class LambdaMember
    {
        private int _value;

        LambdaMember() => Console.WriteLine("consutructor");

        public int Value
        {
            get => this._value;
            set => this._value = Value;
        }

        public DateTime Current => DateTime.Now;

        public int this[int index] => this.Value * index;

        static void Main(string[] args)
        {
            
        }
    }
}
