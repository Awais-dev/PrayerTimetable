using Microsoft.AspNetCore.Mvc;
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

        public PrayerTimesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> FetchTodayPrayerTime(string Url)
        {
            using var response = await _httpClient.GetAsync(Url, HttpCompletionOption.ResponseHeadersRead);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            return result;
        }

    }
}
