using AngularWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApp.Interfaces
{
    public interface IWeatherService
    {
        Task<Weather> GetWeatherAsync(string city);
    }
}
