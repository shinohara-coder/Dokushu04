using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Pro10
{
    internal class DelegateAnonymous
    {
        static void Main(string[] args)
        {
            var drink = "ウイスキー";
            switch (drink)
            {
                case "日本酒":
                case "ビール":
                case "ワイン":
                    Console.WriteLine("醸造酒です。");
                    break;

                case "ブランデー":
                case "ウイスキー":
                case "ウォッカ":
                    Console.WriteLine("蒸留酒です。");
                    break;
            }
        }
    }

}
