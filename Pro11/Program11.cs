using System.Text.RegularExpressions;

namespace Pro11
{
    internal class LockBasicBad
    {

        static void Main(string[] args)
        {
            var tags = "<p><strong>WINGS</strong>サイト<a href='index.html'><img src='wings.jpg'></img></a></p>";
            var rgx = new Regex(@"<.+>");
        }
    }
}

