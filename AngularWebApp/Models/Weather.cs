using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApp.Models
{
    public class Weather
    {
        public string Address { get; set; }
        public DaysWeather[] Days { get; set; }
        public CurrentWeather CurrentConditions { get; set; }

        public class DaysWeather
        {
            public DateTime DateTime { get; set; }
            public decimal Temp { get; set; }
            public decimal Humidity { get; set; }
            public string Conditions { get; set; }

            public HoursDays[] Hours { get; set; } = null;

            public class HoursDays
            {
                public decimal Dew { get; set; }
            }
        }

        public class CurrentWeather
        {
            public DateTime DateTime { get; set; }
            public decimal Temp { get; set; }
            public decimal Feelslike { get; set; }
            public decimal Humidity { get; set; }
            public string Conditions { get; set; }
            public string Sunrise { get; set; }
            public string Sunset { get; set; }
        }
    }
}
