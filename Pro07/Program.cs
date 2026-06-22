using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Pro06
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();

            func($"郵便番号変換後：{FormatPostal(input)}");
        }   

        private static void func(object? str)
        {
            Console.WriteLine(str);
        }

        /// <summary>郵便番号を 〒XXX-XXXX 形式に整形する（7桁の場合のみ）</summary>
        private static string FormatPostal(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return "";
            var digits = new string(raw.Where(char.IsDigit).ToArray());
            if (digits.Length == 7)
            {
                return $"〒{digits[..3]}-{digits[3..]}";
            }
            return raw;
        }
    }
}
