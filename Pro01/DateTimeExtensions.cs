using System;
using System.Collections.Generic;
using System.Text;

namespace Pro01.DateTimeExtensions
{
    internal static class DateTimeExtensions
    {
        public static bool IsToday(this DateTime dt)
        {
            return dt.Date == DateTime.Today;
        }
    }
}
