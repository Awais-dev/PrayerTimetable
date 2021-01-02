using System;
using System.ComponentModel.DataAnnotations;

namespace PrayerTimes.Models
{
    public class Prayer
    {
        public Guid Id { get; set; }

        public string PrayerName { get; set; }

        [Required]
        public string Start { get; set; }

        public Guid PrayerTimetableId { get; set; }
        public PrayerTimetable PrayerTimetable { get; set; }
    }
}