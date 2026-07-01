using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro18
{
    internal class RefForeach
    {
        static void Main(string[] args)
        {
            Console.Write("正数値を入力：");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int score))
            {
                Console.WriteLine(score switch
                {
                    < 0 or > 100 => "異常値",
                    >= 0 and <= 100 => "正常値"
                });
            }
            else
            {
                Console.WriteLine("正数を入力してください。");
            }
        }
    }
}
