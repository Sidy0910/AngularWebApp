using AngularWebApp.Interfaces;
using AngularWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApp.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherController(
            ILogger<WeatherController> logger,
            IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<Weather> GetWeatherAsync([FromQuery] string city)
        {
            var weather = await _weatherService.GetWeatherAsync(city);

            return weather;
        }
    }
}
