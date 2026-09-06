using static System.Console;

namespace Pro11
{    
    internal enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            //var str = (Season)Enum.Parse(typeof(Season), "Summer");
            //var num = (Season)Enum.Parse(typeof(Season), "1");
            //WriteLine($"{str} - {str.GetType()}");
            //WriteLine($"{num} - {num.GetType()}");

            //var success = Enum.TryParse("Winter", out Season s);
            //WriteLine(success ? $"{s}" : "変換失敗");

            var aryEnum = Enum.GetValues(typeof(Season));
            foreach (var name in aryEnum)
            {
                WriteLine($"{(int)name} : {name}");
            }
        }
    }
}

