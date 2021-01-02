using System;
using System.Collections.Generic;

namespace PrayerTimes.Models
{
    public class PrayerTimetable
    {
        public Guid Id { get; set; }

        public string Date { get; set; }

        public ICollection<Prayer> Prayers { get; set; }

    }
}
