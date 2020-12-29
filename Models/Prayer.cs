using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrayerTimes.Models
{
    public class Prayer
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        public DateTime Jamat { get; set; }
    }
}
