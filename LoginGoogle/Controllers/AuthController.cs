using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;
using LoginGoogle.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LoginGoogle.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthenticationSchemeProvider authenticationSchemeProvider;
        public AuthController(IAuthenticationSchemeProvider authenticationSchemeProvider)
        {
            this.authenticationSchemeProvider = authenticationSchemeProvider;
        }
        public async Task<IActionResult> Login()
        {
            var allSchemeProvider = (await authenticationSchemeProvider.GetAllSchemesAsync())
                .Select(n => n.DisplayName).Where(n => !String.IsNullOrEmpty(n));
            return View(allSchemeProvider);
        }
        public IActionResult SignIn(String provider)
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" }, provider);
        }
        public async Task<IActionResult> SignOut(String provider)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult GetFaceBookInfo()
        {
            WebClient client = new WebClient();
            client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            var data = client.DownloadString("https://graph.facebook.com/oauth/access_token?grant_type=fb_exchange_token&client_id=4398183950223941&client_secret=2830e4531ed603c39c91e4b1ff8d230b&fb_exchange_token=EAAZBgIAACikUBAKd5khJy0EbNzKoRKEBbZCfCZABLYR6UoQUNi4bZAVhjlfZCZC023d0ljSqEZAZBluoki3VomgD59fovZAZBrnvRWtjJTeZC6txhDDbDTd4qm0cZAtdyGFrvdfljZA68nQYH9IlceLUuZCgoxxO0KOblVYVUQZCFr6GJByPQZDZD");
            string token = data.Remove(0, 17);
            token = token.Remove(token.Length - 45);
            ViewBag.Data = token;
            WebClient client1 = new WebClient();
            var data1 = client1.DownloadString("https://graph.facebook.com/v8.0/me?fields=id%2Cname%2Cpicture%2Clink&access_token="+token+"");
            User datauser = JsonConvert.DeserializeObject<User>(data1);
            ViewBag.Data0 = datauser.name;
            ViewBag.Data1 = datauser.link;
            ViewBag.Data2 = datauser.id;
            ViewBag.Data3 = datauser.picture.data.url;
            ViewBag.H = datauser.picture.data.height;
            ViewBag.W = datauser.picture.data.width;
            return View("UserInfo");
        }
    }
}
