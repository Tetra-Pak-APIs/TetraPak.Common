using System;

namespace TetraPak
{
    public static class DateTimeHelper
    {
        static readonly DateTime s_epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); 
        
        public static DateTime EpochToDateTime(this long self)
        {
            return s_epoch.AddSeconds(self);
        }

        public static DateTime EpochToDateTime(this int self) => ((long) self).EpochToDateTime();
    }
}