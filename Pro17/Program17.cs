using System.Text.RegularExpressions;
using static System.Console;

namespace Pro17
{
    internal class TwoFreeArray
    {
        private int[] _size = { };
        private int[,] _list = { };

        public TwoFreeArray(int size1, int size2)
        {
            this._size = new[] { size1, size2 };
            this._list = new int[size1, size2];
        }

        public int this[int index1, int index2]
        {
            set
            {
                this._list[this.GetIndex(index1, 0),
                            this.GetIndex(index2, 1)] = value;
            }

            get
            {
                return this._list[this.GetIndex(index1, 0),
                        this.GetIndex(index2, 1)];
            }
        }

        private int GetIndex(int index, int dimension)
        {
            if (index < 0)
            {
                return 0;
            }
            return index % this._size[dimension];
        }

    }

    internal class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            var array = new TwoFreeArray(3, 2);
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = k++;
                }
            }

            WriteLine(array[2, 1]);
            WriteLine(array[-20, -63]);
            WriteLine(array[458, 752]);
        }
    }
}
