using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using static System.Console;

namespace Pro10
{
    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            var str = "<p>サポートサイト<a href='https://www.wings.msn.to/'>https://www.wings.msn.to/</a></p>";
            //var rgx = new Regex(@"<a href='(.+?)'>\1</a>");
            var rgx = new Regex(@"<a href='(?<link>.?)'>\k<link>></a>");
            var match = rgx.Match(str);
            if(match.Success)
            {
                WriteLine(match.Value);
            }
        }
    }
}