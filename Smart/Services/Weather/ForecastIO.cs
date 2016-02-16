using Smart.Services.Geo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForecastIO;
using ForecastIO.Extensions;
using Microsoft.Extensions.Options;

namespace Smart.Services.Weather
{
    public class ForecastIO : IForecast
    {
        private IGeoTranslate geo;
        private ForecastOptions options;

        public ForecastIO(IGeoTranslate geoTranslator, IOptions<ForecastOptions> options)
        {
            this.options = options.Value;
            this.geo = geoTranslator;
        }

        public ForecastIOResponse GetForecast()
            => GetForecast(options.ZipCode);

        public ForecastIOResponse GetForecast(int zipCode)
            => GetForecast(this.geo.GetLatLong(zipCode));

        public ForecastIOResponse GetForecast(Tuple<float, float> latLong)
            => GetForecast(latLong.Item1, latLong.Item2);

        public ForecastIOResponse GetForecast(float lat, float longitude)
            => new ForecastIORequest(options.APIKey, lat, longitude, Unit.us).Get();
    }
}
