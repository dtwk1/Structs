using System;

namespace Stucts
{
    public struct Age
    {
        private double Value;
        
        private static readonly long TicksInAYear=  365 *  TimeSpan.TicksPerDay+ 5   *  TimeSpan.TicksPerHour+ 48 *  TimeSpan.TicksPerMinute+  46 * TimeSpan.TicksPerSecond;

        public Age(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be larger than 0");
            }

            this.Value = value;
        }

        public Age(TimeSpan value):this(value.Ticks/TicksInAYear)
        {
        }


        public static implicit operator TimeSpan(Age d) => new TimeSpan((long)(d.Value * TicksInAYear));


        public static implicit operator double(Age d) => d.Value;


        public static implicit operator Age(TimeSpan d) => new Age(d);
    }
}
