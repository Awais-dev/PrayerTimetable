using Newtonsoft.Json;
using PrayerTimes.Models;
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

        public async Task<Rootobject> FetchTodayPrayerTime(string Url)
        {
            using var response = await _httpClient.GetAsync(Url, HttpCompletionOption.ResponseHeadersRead);

            response.EnsureSuccessStatusCode();

            var resultString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Rootobject>(resultString);
        }

    }
}
