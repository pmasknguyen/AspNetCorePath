using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisBookings.Web.Services
{
    public class AmazingForecaster
    {
        public WeatherResult GetWeatherResult()
        {
            return new WeatherResult {
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}
