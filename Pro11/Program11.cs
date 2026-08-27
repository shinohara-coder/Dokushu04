using System.CodeDom;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Pro11
{
    internal class TwoFreeArray
    {
        private int[] _size;
        private int[,] _list;

        public TwoFreeArray(int size1, int size2)
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

        private int GetIndex(int index, int dimension)
        {
            if (index < 0)
            {
                return 0;
            }
            return index % this._size[dimension];   //0次元か、1次元か
        }
    }
    
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var dim1_size = 3;
            var dim2_size = 2;
            var array = new TwoFreeArray(dim1_size, dim2_size);
            var k = 1;
            for (var i = 0; i < dim1_size; i++)
            {
                for (var j = 0; j < dim2_size; j++)
                {
                    array[i, j] = k++;
                }
            }

            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.WriteLine($"array[{i},{j}] = {array[i, j]}");
                }
            }
        }
    }
}

