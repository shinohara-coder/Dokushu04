using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro15
{
    [Flags]
    enum FontStyle
    {
        Bold = 1,
        Italic = 2,
        Underline = 4,
        All = (Bold | Italic | Underline),
    }
    
    internal class PassReIn
    {
        static void Main(string[] args)
        {
            var styles = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;

            if (styles.HasFlag(FontStyle.Bold))
            {
                Console.WriteLine("太字指定されています。");
            }

            if (styles.HasFlag(FontStyle.Bold | FontStyle.Italic))
            {
                Console.WriteLine("太字&斜体指定されています。");
            }

            Console.WriteLine(styles);
        }
    }
}
