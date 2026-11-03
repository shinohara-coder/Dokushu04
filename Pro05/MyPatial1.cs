using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Pro05
{
    internal static class StringExtensions
    {
        public static string Repeat(this string str, int count)
        {
            var builder = new StringBuilder();
            for (var i = 1; i <= count; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }
    }
}
