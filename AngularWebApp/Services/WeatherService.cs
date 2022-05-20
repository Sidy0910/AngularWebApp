using AngularWebApp.Interfaces;
using AngularWebApp.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AngularWebApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public WeatherService(
            IConfiguration configuration,
            HttpClient httpClient)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<Weather> GetWeatherAsync(string city)
        {
            Weather weather = new Weather();
            var url = _configuration.GetValue<string>("Weather:Url");
            var key = _configuration.GetValue<string>("Weather:Key");
            
            try
            {
                HttpResponseMessage res = await _httpClient.GetAsync($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}?unitGroup=metric&key=H8ZUS5Q6UZCU4PB6EABVK47QJ&contentType=json");

                if (res.IsSuccessStatusCode)
                {
                    var jsonString = await res.Content.ReadAsStringAsync();
                    weather = JsonConvert.DeserializeObject<Weather>(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return weather;
        }
    }
}
