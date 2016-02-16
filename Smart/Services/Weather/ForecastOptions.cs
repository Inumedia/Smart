using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Services.Weather
{
    public class ForecastOptions
    {
        public string APIKey;
        public int ZipCode;
    }
}
