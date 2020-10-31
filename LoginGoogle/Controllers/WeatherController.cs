using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using LoginGoogle.Models;
using Nancy.Json;
using System.Globalization;

namespace LoginGoogle.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetWeatherInfo(string City)
        {
            string appid = "a33e61c9ad61dd15db3151dec6c4e5e0";
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + City + "&units=metric&appid=" + appid);
            using (WebClient client = new WebClient())
            {
                string json;
                ViewBag.Flag = 0;
                try
                {
                    json = client.DownloadString(url);
                    WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);
                    ViewBag.Name = weatherInfo.name;
                    ViewBag.LinkIcon = "http://openweathermap.org/img/wn/" + weatherInfo.weather[0].icon + "@2x.png";
                    ViewBag.WeatherMin = weatherInfo.weather[0].main.ToUpper();
                    ViewBag.CountryFlag = string.Format("https://www.countryflags.io/{0}/flat/64.png", weatherInfo.sys.country.ToLower());
                    ViewBag.Temp = weatherInfo.main.temp;
                    ViewBag.X = weatherInfo.coord.lon.ToString(new CultureInfo("en-US"));
                    ViewBag.Y = weatherInfo.coord.lat.ToString(new CultureInfo("en-US"));
                    ViewBag.TempMax = weatherInfo.main.temp_max;
                    ViewBag.TempMin = weatherInfo.main.temp_min;
                    ViewBag.CountryName = weatherInfo.sys.country;
                    ViewBag.Weather = weatherInfo.weather[0].description.ToUpper();
                    ViewBag.WindSpeed = weatherInfo.wind.speed;
                    ViewBag.Clound = weatherInfo.clouds.all;
                    ViewBag.Timezone = weatherInfo.timezone;
                }
                catch
                {
                    ViewBag.Flag = 1;
                }
            }
            return View("WeatherInfo");
        }
    }
}
