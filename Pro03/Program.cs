using System;
using static System.Console;
using static System.Math;

namespace Pro03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Devide(10, 0);
            }
            catch (Exception)
            {
                Console.WriteLine("【メイン画面】エラーが発生したため、処理を中断しました。");
            }
        }

        static void Devide(int a, int b)
        {
            try
            {
                int result = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("【システムログ】0で割ろうとする計算が発生しました。確認してください。");
                throw;
            }
        }
    }
}
