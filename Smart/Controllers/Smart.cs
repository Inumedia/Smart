using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Smart.Services.Geo;
using Smart.Services.Weather;
using Smart.ViewModels.Smart;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Smart.Controllers
{
    public class Smart : Controller
    {
        private readonly IGeoTranslate geo;
        private readonly IForecast weather;

        public Smart(IForecast weather, IGeoTranslate geo)
        {
            this.geo = geo;
            this.weather = weather;
        }
    }
}
