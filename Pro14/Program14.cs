using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro14
{
    internal class DelegeteUseCounter
    {
        static void ShowMatch(string msg, Regex reg)
        {
            var matches = reg.Matches(msg);
            foreach (Match result in matches)
            {
                WriteLine(result.Value);
            }
            WriteLine("------------------------------");
        }
        static void Main(string[] args)
        {
            var msg = "ただいま、WINGSプロジェクトメンバー募集中です！";
            ShowMatch(msg, new Regex(@"\p{IsHiragana}+"));
            ShowMatch(msg, new Regex(@"\p{IsKatakana}+"));
            ShowMatch(msg, new Regex(@"\p{IsCJKUnifiedIdeographs}+"));
        }
    }
}
