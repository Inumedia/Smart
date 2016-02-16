using ForecastIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Services.Weather
{
    public interface IForecast
    {
        ForecastIOResponse GetForecast();
        ForecastIOResponse GetForecast(int zipCode);
        ForecastIOResponse GetForecast(float lat, float longitude);
        ForecastIOResponse GetForecast(Tuple<float, float> latLong);
    }
}
