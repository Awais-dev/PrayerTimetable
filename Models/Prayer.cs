using System;
using System.ComponentModel.DataAnnotations;

namespace PrayerTimes.Models
{
    public class Prayer
    {
        public Guid Id { get; set; }

        [Required]
        public string Start { get; set; }
    }
}
