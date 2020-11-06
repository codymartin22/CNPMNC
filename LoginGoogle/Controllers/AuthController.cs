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
    }
}
