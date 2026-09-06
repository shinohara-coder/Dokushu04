using static System.Console;

namespace Pro10
{
    [Flags]
    enum FontStyle
    {
        Bold=1,
        Italic=2,
        Underline=4,
        NonBold = (Italic | Underline),
        All=(Bold|Italic|Underline)
    }
    internal class AsuncBasic
    {
        static void Main(string[] args)
        {
            //var styles = FontStyle.Bold | FontStyle.Italic;
            //var styles = FontStyle.All;
            var styles = FontStyle.NonBold;
            if(styles.HasFlag(FontStyle.Bold))
            {
                WriteLine("太字で指定されています。");
            }

            if (styles.HasFlag(FontStyle.Bold | FontStyle.Italic))
            {
                WriteLine("太字&斜体で指定されています。");
            }

            if (styles.HasFlag(FontStyle.Bold | FontStyle.Italic | FontStyle.Underline))
            {
                WriteLine("全てのフラグが立っています。");
            }

            if (styles.HasFlag(FontStyle.NonBold))
            {
                WriteLine("太字ではありません。");
            }

            WriteLine(styles);
        }
    }

}
