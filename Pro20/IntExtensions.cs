using System.Runtime.CompilerServices;

namespace Pro20.IntExtensions
{
    internal static class IntExtensions
    {
        public static void Times(this int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
    }
}
