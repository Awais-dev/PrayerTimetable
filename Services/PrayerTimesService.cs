using Newtonsoft.Json;
using PrayerTimes.Data;
using PrayerTimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrayerTimes.Services
{
    public class PrayerTimesService : IPrayerTimesService
    {
        private readonly HttpClient _httpClient;

        private readonly ApplicationDbContext _applicationDbContext;


        public PrayerTimesService(HttpClient httpClient, ApplicationDbContext applicationDbContext)
        {
            _httpClient = httpClient;
            _applicationDbContext = applicationDbContext;

        }

        public async Task<PrayerTimetable> GetDailyPrayerTimes(string url)
        {
            var prayerTimes = await FetchTodayPrayerTime(url);

            var existingTimetable = _applicationDbContext.PrayerTimetables
              .FirstOrDefault(e => e.Date == prayerTimes.data.date.readable);


            var mappedPrayerTimes = Map(prayerTimes);

            _applicationDbContext.PrayerTimetables.Add(mappedPrayerTimes);

            await _applicationDbContext.SaveChangesAsync();

            return mappedPrayerTimes;

        }

        private PrayerTimetable Map(Rootobject prayerTimes)
        {
            var prayerTimeDto = new PrayerTimetable
            {
                Id = Guid.NewGuid(),
                Date = prayerTimes.data.date.readable,
                Prayers = new List<Prayer>()
            };
            var fajr = new Prayer
            {
                Id = Guid.NewGuid(),
                PrayerName = "Fajr",
                Start = prayerTimes.data.timings.Fajr,
                PrayerTimetableId = prayerTimeDto.Id
            };

            var dhuhr = new Prayer
            {
                Id = Guid.NewGuid(),
                PrayerName = "Dhuhr",
                Start = prayerTimes.data.timings.Dhuhr,
                PrayerTimetableId = prayerTimeDto.Id
            };

            var asr = new Prayer
            {
                Id = Guid.NewGuid(),
                PrayerName = "Asr",
                Start = prayerTimes.data.timings.Asr,
                PrayerTimetableId = prayerTimeDto.Id
            };

            var maghrib = new Prayer
            {
                Id = Guid.NewGuid(),
                PrayerName = "Maghrib",
                Start = prayerTimes.data.timings.Maghrib,
                PrayerTimetableId = prayerTimeDto.Id
            };

            var isha = new Prayer
            {
                Id = Guid.NewGuid(),
                PrayerName = "Isha",
                Start = prayerTimes.data.timings.Fajr,
                PrayerTimetableId = prayerTimeDto.Id
            };


            prayerTimeDto.Prayers.Add(fajr);
            prayerTimeDto.Prayers.Add(dhuhr);
            prayerTimeDto.Prayers.Add(asr);
            prayerTimeDto.Prayers.Add(maghrib);
            prayerTimeDto.Prayers.Add(isha);

            return prayerTimeDto;
        }

        private async Task<Rootobject> FetchTodayPrayerTime(string Url)
        {
            using var response = await _httpClient.GetAsync(Url, HttpCompletionOption.ResponseHeadersRead);

            response.EnsureSuccessStatusCode();

            var resultString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Rootobject>(resultString);
        }
    }
}
