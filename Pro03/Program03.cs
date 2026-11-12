using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal enum Season : int
    {
        Spring,
        Summer,
        Autumn,
        Winter,
        All = Spring + Summer + Autumn + Winter
    }

    internal class SeasonEnum
    {
        public void ProcessSeason(Season season)
        {
            WriteLine(season);
        }
    }

    internal class PassRefReturn
    {
        static void Main(string[] args)
        {
            //var sc = new SeasonEnum();
            //sc.ProcessSeason((int)Season.Spring);
            //sc.ProcessSeason((int)Season.Autumn);
            //sc.ProcessSeason(4);

            var all = Season.All;
            WriteLine(all);
            WriteLine(all.ToString());
            WriteLine(all.ToString("D"));
            WriteLine(all.ToString("X"));
        }
    }
}

