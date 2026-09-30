using static System.Console;

namespace Pro23
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            var rank = "乙";

            switch (rank)
            {
                case "甲":
                    WriteLine("大変良いです。");
                    goto case "丙";
                case "乙":
                    WriteLine("良いです。");
                    goto case "丙";
                case "丙":
                    WriteLine("合格です。");
                    break;
                case "丁":
                    WriteLine("がんばりましょう。");
                    break;
                default:
                    WriteLine("？？？");
                    break;
            }
        }
    }
}

