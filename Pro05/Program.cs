using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Pro05
{
    internal class JapaneseMonth
    {
        private string[] _month =
            {"睦月", "如月", "弥生", "卯月", "皐月", "水無月", "文月", 
            "葉月", "長月", "神無月", "霜月", "師走"};

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

    internal class MyClass
    {
        static void Main(string[] args)
        {
            var mon = new JapaneseMonth();
            Console.WriteLine(mon["神無月"]);
            Console.WriteLine(mon[12]);
        }
    }

}
