using ForecastIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.ViewModels.Smart
{
    public class SmartViewModel
    {
        public SmartViewModel(ForecastIOResponse forecast)
        {
            this.Forecast = forecast;
        }

        public readonly ForecastIOResponse Forecast;
        public readonly DateTime Now = DateTime.Now;
    }
}
