using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Smart.Services.Geo;

namespace Smart.Controllers
{
    public class HomeController : Controller
    {
        private IGeoTranslate geo;

        public HomeController(IGeoTranslate geoServices)
        {
            this.geo = geoServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}