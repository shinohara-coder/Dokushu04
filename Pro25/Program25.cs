using System.Globalization;
using static System.Console;


namespace Pro25
{
    internal partial class MyPartialMethod
    {
        static void Main(string[] args)
        {
            //var str = "叱る";
            //var strInfo = new StringInfo(str);
            //WriteLine($"文字列\"{str}\"の長さは{strInfo.LengthInTextElements}");

            var str1 = "wings";
            var str2 = "WINGS";

            WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
            WriteLine(string.Compare(str1, str2));
            WriteLine(string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase));
        }
    }
}
