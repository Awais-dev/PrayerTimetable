using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrayerTimes.Services
{
    public interface IPrayerTimesService
    {
        public Task<string> FetchTodayPrayerTime(string Url);
    }
}
