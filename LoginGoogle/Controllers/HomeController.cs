using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginGoogle.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http.Features;
using Nancy.Json;
using X.PagedList.Mvc;
using X.PagedList;
using X.PagedList.Web;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LoginGoogle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(string search, int? page)
        {
            using (StreamReader r = new StreamReader(@"CityData\city.list.json"))
            {
                string json = r.ReadToEnd();
                List<City> cityList = JsonConvert.DeserializeObject<List<City>>(json);
                if (search == null)
                {
                    return View(cityList.ToPagedList(page ?? 1, 50));
                }
                else
                {
                    return View(cityList.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToPagedList());
                }

            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
