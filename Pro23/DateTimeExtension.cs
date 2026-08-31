namespace Pro23.DateTimeExtension
{
    internal static class DateTimeExtension
    {
        public static bool IsToday(this DateTime dt)
        {
            return dt.Date == DateTime.Today;
        }
    }
}
