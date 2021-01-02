using PrayerTimes.Models;
using System.Threading.Tasks;

namespace PrayerTimes.Services
{
    public interface IPrayerTimesService
    { 
        public Task<PrayerTimetable> GetDailyPrayerTimes(string url);
    }
}
