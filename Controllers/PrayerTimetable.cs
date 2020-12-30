using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PrayerTimes.Services;

namespace PrayerTimes.Controllers
{
    public class PrayerTimetable : Controller
    {
        string url = "http://api.aladhan.com/v1/timingsByAddress?address=Birmingham,UK";

        private readonly IPrayerTimesService _prayerTimesService;
        public PrayerTimetable(IPrayerTimesService prayerTimesService)
        {
            _prayerTimesService = prayerTimesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DailyPrayerTimes()
        {

            var prayerTimes = await _prayerTimesService.FetchTodayPrayerTime(url);

            return Ok(prayerTimes);
        }
    }
}
