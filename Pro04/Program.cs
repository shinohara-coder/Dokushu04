using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro04
{
    internal class TwoFreeArray
    {
        private int[] _size;
        private int[,] _list;

        internal TwoFreeArray(int size1, int size2)
        {
            this._size = new[] { size1, size2 };
            this._list = new int[size1, size2];
        }

        public int this[int index1, int index2]
        {
            set
            {
                this._list[this.GetIndex(index1, 0), this.GetIndex(index2, 1)] = value;
            }

            get
            {
                return this._list[this.GetIndex(index1, 0), this.GetIndex(index2, 1)];
            }
        }

        // インデックスを循環させて取得するメソッド
        private int GetIndex(int index, int dimension)
        {
            if (index < 0)
            {
                return 0;
            }
            return index % this._size[dimension];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new TwoFreeArray(3, 2);
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = k++;
                }
            }

            Console.WriteLine(arr[51, 99]);
            Console.WriteLine(arr[-1, 0]);
            Console.WriteLine(arr[4, 0]);
        }
    }
}
