using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro20
{
    internal class PrimeNumber
    {
        internal IEnumerable<int> GetPrimes(int max)
        {
            bool IsPrime(int value)
            {
                bool prime = true;
                for (int i = 2; i <= Math.Floor(Math.Sqrt(value)); i++)
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

            for (int num = Min; num <= max; num++)
            {
                if (IsPrime(num))
                {
                    yield return num;
                }
            }
        }
    }
    
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var p = new PrimeNumber();
            Console.WriteLine("正の整数値を入力してください。");
            string? result = Console.ReadLine();

            if (int.TryParse(result, out int num))
            {
                var primes = p.GetPrimes(num);
                foreach (int value in primes)
                {
                    func(value);
                }
            }
            else
            {
                func("正の整数値を入力してください。");
            }
            
        }

        static void func(object? obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
