using System;
using System.Collections.Generic;
using System.Text;

namespace Pro19
{
    internal static class StringExtensions
    {
        public static string Repeat(this string str, int count)
        {
            var builder = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }
    }
}
