using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro10
{
    internal class PrimeNumber
    {
        public IEnumerable<int> GetPrimes(int max)
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

            if (max < Min)
            {
                WriteLine($"引数{nameof(max)}は2以上の値を指定してください。");
                yield break;
            }

            for (var num = Min; num <= max; num++)
            {
                if (IsPrime(num))
                {
                    yield return num;
                }
            }
        }
    }

    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            var p = new PrimeNumber();
            var primeNums = p.GetPrimes(1);
            foreach (var value in primeNums)
            {
                WriteLine(value);
            }
        }
    }
}