using Smart.Services.Geo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForecastIO;
using ForecastIO.Extensions;

namespace Smart.Services.Weather
{
    public class ForecastIO : IForecast
    {
        private IGeoTranslate geo;

        public ForecastIO(IGeoTranslate geoTranslator)
        {
            this.geo = geoTranslator;
        }
        public void GetForecast(int zipCode)
        {
            Tuple<float, float> latLong = this.geo.GetLatLong(zipCode);
        }
    }
}
