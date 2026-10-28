using System.Collections;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro12
{
    internal class PrimeList : IEnumerable<int>
    {
        int _max = 2;

        public PrimeList(int max)
        {
            this._max = max;
        }

        public IEnumerator<int> GetEnumerator()
        {
            bool IsPrime(int value)
            {
                var prime = true;
                var mid = Math.Floor(Math.Sqrt(value));
                for (var i = 2; i <= mid; i++)
                {
                    if (value % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                return prime;
            }

            const int Min = 2;

            if (this._max < Min)
            {
                WriteLine($"引数{nameof(_max)}は2以上を指定してください。");
                yield break;
            }

            for (var num = Min; num <= this._max; num++)
            {
                if (IsPrime(num))
                {
                    yield return num;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    internal class ScopeBasic
    {

        static void Main(string[] args)
        {
            var list = new PrimeList(1000);
            foreach(var value in list)
            {
                WriteLine(value);
            }
        }
    }
}

