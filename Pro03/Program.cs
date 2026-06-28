using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro03
{
    internal class FreeArray
    {
        private int _size;
        private int[] _list;

        internal FreeArray(int size)
        {
            this._size = size;
            this._list = new int[size];
        }

        public int this[int index]
        {
            set
            {
                this._list[this.GetIndex(index)] = value;
            }

            get
            {
                return this._list[this.GetIndex(index)];
            }
        }

        private int GetIndex(int index)
        {
            if (index < 0)
            {
                return 0;
            }
            return index % this._size;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new FreeArray(5);
            arr[0] = 1;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 30;
            arr[4] = 60;

            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[-10]);
            Console.WriteLine(arr[9]);
        }
    }
}
