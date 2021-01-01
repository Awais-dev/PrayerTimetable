using System;
using System.ComponentModel.DataAnnotations;

namespace PrayerTimes.Models
{
    public class PrayerTimetable
    {
        public Guid Id { get; set; }

        [Required]
        public Date Date { get; set; }

        public Prayer Fajr { get; set; }

        public Prayer Dhuhr { get; set; }

        public Prayer Asr { get; set; }

        public Prayer Maghrib { get; set; }

        public Prayer Isha { get; set; }

    }
}
