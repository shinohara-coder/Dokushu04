using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Math;

namespace Pro03
{
    internal class Person
    {
        private string firstName = "";
        private string lasttName = "";

        public Person (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lasttName = lastName;
        }

        public string Show()
        {
            return $"名前は{this.lasttName}{this.firstName}です。";
        }
    }
    
    internal class Program
    {
        [DllImport("kernel32.dll")]
        private extern static bool Beep(uint dwFreq, uint dwDuration);
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田");
            func(p.Show());

            Beep(440, 200);
            Beep(660, 200);
            Beep(880, 200);
            Beep(1200, 200);

            double Discount(int price, double rate)
            {
                return price * (1 - rate);
            }

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int price))
            {
                func($"定価：{price} 2割引後価格：{Discount(price, 0.2)}");
            }
            else
            {
                func("エラー：整数値を入力してください。");
            }
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }
    }
}
