using Pro05;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    [Flags]
    enum FontStyle
    {
        Bold = 1,
        Italic = 2,
        Underline = 4,
        All = (Bold | Italic | Underline),
        NonBold = (Italic | Underline),
    }

    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            //var styles = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
            var styles = FontStyle.NonBold;

            if (styles.HasFlag(FontStyle.Bold))
            {
                WriteLine("太字指定");
            }

            if (styles.HasFlag(FontStyle.Bold | FontStyle.Italic))
            {
                WriteLine("太字＆斜体");
            }

            WriteLine(styles);
        }
    }
}

