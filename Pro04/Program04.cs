using System.Collections;

namespace SelfCSharp.Chap09.Priority1
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
                var mid = (int)Math.Floor(Math.Sqrt(value));
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
                Console.WriteLine("引数maxは2以上の値を指定してください。");
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
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var list = new PrimeList(100);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}

