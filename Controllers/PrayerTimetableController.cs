using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PrayerTimes.Services;
using System.Text.Json;
using Newtonsoft.Json;
using PrayerTimes.Models;
using PrayerTimes.Data;

namespace PrayerTimes.Controllers
{
    public class PrayerTimetableController : Controller
    {
        string url = "http://api.aladhan.com/v1/timingsByAddress?address=Birmingham,UK";

        private readonly IPrayerTimesService _prayerTimesService;

        private readonly ApplicationDbContext _applicationDbContext;
        public PrayerTimetableController(
            IPrayerTimesService prayerTimesService,
            ApplicationDbContext applicationDbContext)
        {
            _prayerTimesService = prayerTimesService;
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetDailyPrayerTimes()
        {

            var prayerTimes = await _prayerTimesService.FetchTodayPrayerTime(url);

            var mappedPrayerTimes = Map(prayerTimes);

            _applicationDbContext.Add(mappedPrayerTimes);

            await _applicationDbContext.SaveChangesAsync();

            return Ok(mappedPrayerTimes);
        }

        public PrayerTimetable Map(Rootobject prayerTimes)
        {
            var prayerTimeDto = new PrayerTimetable()
            {
                Id = Guid.NewGuid(),
                Date = prayerTimes.data.date,
                Fajr =
                {
                    Id = Guid.NewGuid(),
                    Start = prayerTimes.data.timings.Fajr
                },
                Dhuhr =
                {
                    Id = Guid.NewGuid(),
                    Start = prayerTimes.data.timings.Dhuhr
                },
                Asr =
                {
                    Id = Guid.NewGuid(),
                    Start = prayerTimes.data.timings.Asr
                },
                Maghrib =
                {
                    Id = Guid.NewGuid(),
                    Start = prayerTimes.data.timings.Maghrib
                },
                Isha =
                {
                    Id = Guid.NewGuid(),
                    Start = prayerTimes.data.timings.Isha
                }
            };

            return prayerTimeDto;
        }
    }
}
