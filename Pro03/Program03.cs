using System.Globalization;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Season
    {
        public const int Spring = 0;
        public const int Summer = 1;
        public const int Autumn = 2;
        public const int Winter = 3;

        public void ProcessSeason(int season)
        {
            WriteLine(season);
        }
    }
    
    internal class PassRefReturn
    {
        static void Main(string[] args)
        {
            
        }
    }
}

