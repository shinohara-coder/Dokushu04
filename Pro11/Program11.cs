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
    
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            
        }
    }
}

