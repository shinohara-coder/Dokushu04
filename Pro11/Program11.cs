using System.Runtime.InteropServices;
using static System.Console;

namespace Pro12
{    
    
    internal class ScopeBasic
    {
        public string data = "フィールド";

        public string Show()
        {
            string data = "ローカル";
            //隠ぺいされたフィールドにアクセス
            return this.data;
        }

        static void Main(string[] args)
        {
            var s = new ScopeBasic();
            WriteLine(s.Show());
            WriteLine(s.data);
        }
    }
}

