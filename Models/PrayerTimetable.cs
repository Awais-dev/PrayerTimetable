using System;
using System.ComponentModel.DataAnnotations;

namespace PrayerTimes.Models
{
    public class PrayerTimetable
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Day { get; set; }

        public string Month { get; set; }

        public Prayer Fajr { get; set; }

        public DateTime Sunrise { get; set; }

        public Prayer Dhuhr { get; set; }

        public Prayer Asr { get; set; }

        public Prayer Maghrib { get; set; }

        public Prayer Isha { get; set; }

    }
}
