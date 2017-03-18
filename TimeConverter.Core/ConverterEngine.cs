using System;
using System.Linq;

namespace TimeConverter.Core
{
    public class ConverterEngine
    {
        private static TimeZoneInfo MelbourneTimeZone { get; } 
            = TimeZoneInfo.GetSystemTimeZones().Single(tz => tz.Id.Equals("AUS Eastern Standard Time"));

        public static DateTimeOffset ConvertMelbourneTimeToUtc(DateTime dateTime)
        {          
            return MelbourneTimeZone.ToDateTimeOffset(dateTime).ToUniversalTime();
        }

        public static DateTimeOffset ConvertUtcToMelbourneTime(DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, MelbourneTimeZone);
        }
    }
}
