using System.Text;

namespace Pro20
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
