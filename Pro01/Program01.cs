//#define DEBUG
using SelfCSharp.Chap09.Priority1;
using System;
using System.Collections;
using System.Globalization;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PrimeList : IEnumerable<int>
    {
        int max = 2;
        public PrimeList(int max)
        {
            this.max = max;
        }

        public IEnumerator<int> GetEnumerator()
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
            if (this.max < Min)
            {
                Console.WriteLine("引数maxは2以上の値を指定してください。");
                yield break;
            }

            for (int num = Min; num <= this.max; num++)
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
            Console.WriteLine("正の整数値を入力してください。");
            string? result = Console.ReadLine();

            if (int.TryParse(result, out int num))
            {
                var list = new PrimeList(num);
                foreach (int value in list)
                {
                    Console.WriteLine(value);
                }
            }
            else
            {
                Console.WriteLine("正の整数値を入力してください。");
            }
        }
    }
}


