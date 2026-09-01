using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Pro24.StringExtensions
{
    internal static class StringExtensions
    {
        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str)) return str;
            if (str.Length <= maxLength) return str;

            return str.Substring(0, maxLength) + "...";
        }
    }
}
