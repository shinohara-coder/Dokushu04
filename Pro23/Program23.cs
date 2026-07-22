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

        static void Main(string[] args)
        {
            
        }
    }
}
