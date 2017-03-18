using System;

namespace TimeConverter.Core
{
    public static class TimeZoneInfoExtensions
    {
        public static DateTimeOffset ToDateTimeOffset(this TimeZoneInfo timeZoneInfo, DateTime dateTime)
        {
            return new DateTimeOffset(dateTime, timeZoneInfo.GetUtcOffset(dateTime));
        }
    }
}