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

        public PrayerTimetableController(IPrayerTimesService prayerTimesService)
        {
            _prayerTimesService = prayerTimesService;
        }

        public async Task<IActionResult> Index()
        {
            var prayerTimes = await _prayerTimesService.GetDailyPrayerTimes(url);

            return Ok(prayerTimes);
        }
    }
}
