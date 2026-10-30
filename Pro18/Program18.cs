using System.Text.RegularExpressions;
using Pro17;
using static System.Console;

namespace Pro18
{
    internal class JapaneseMonth
    {
        private string[] _month = {"睦月", "如月", "弥生", "卯月", "皐月",
          "水無月", "文月", "葉月", "長月", "神無月", "霜月", "師走" };

        public JapaneseMonth() { }

        public int this[string name]
        {
            get
            {
                return Array.IndexOf(this._month, name) + 1;
            }
        }

        public string this[int index]
        {
            get
            {
                return this._month[index - 1];
            }
        }
    }

    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            var mon = new JapaneseMonth();
            var mon_str = "無月";
            var mon_num = 7;
            WriteLine($"{mon_str}は{mon[mon_str]}月");
            WriteLine($"{mon[mon_num]}は{mon_num}月");
        }
    }
}

