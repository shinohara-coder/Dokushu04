using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pro06.Extension
{
    public static class IntExtensions
    {
        public static void Times(this int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
    }

    public static class DateTimeExtensions
    {
        public static bool IsToday(this DateTime dt)
        {
            return dt.Date == DateTime.Today;
        }
    }

    public static class StringExtensions
    {
        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str)) return str;
            if (str.Length <= maxLength) return str;

            return str.Substring(0, maxLength) + "...";
        }
    }
}
