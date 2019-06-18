using System;
using System.Collections.Generic;
using System.Text;

namespace Structs
{
    using Stucts;

    public struct DateOfBirth
    {
        private DateTime value;

        public DateOfBirth(DateTime dateTime)
        {
            if (dateTime > DateTime.Now)
            {
                throw new ArgumentException($"Date of birth {dateTime.ToString("u")} occurs in the future");
            }

            this.value = dateTime;
        }

        public DateOfBirth(int year, int month, int day) : this(new DateTime(year, month, day))
        {
        }


        public static implicit operator DateTime(DateOfBirth d) => d.value;


        public Age GetAge() => new Age(DateTime.Now - value);
    }
}
