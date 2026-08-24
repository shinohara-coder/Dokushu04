using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace SelfCSharp.Chap09.Priority1
{   
    internal class PrimeNumber
    {
        public IEnumerable<int> GetPrimes(int max)
        {
            bool IsPrime(int value)
            {
                var prime = true;
                for (var i = 2; i <= Math.Floor(Math.Sqrt(value)); i++)
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
                Console.WriteLine("引数maxは2以上の値を指定してください。");
                yield break;
            }
        }
    }
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            
        }
    }
}

