using System;
using System.Runtime.Serialization;

namespace Dokushu04
{
    internal class LambdaMember
    {
        private int _value;

        LambdaMember() => Console.WriteLine("constructor");

        public int Value
        {
            get => this._value;
            set => this._value = value;
        }

        public DateTime Current => DateTime.Now;

        public int this[int index] => this.Value * index;

        public int Calculate() => this.Value * this.Value;

        static void Main(string[] args)
        {
            
        }
    }
}
