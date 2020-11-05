using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace LoginGoogle.Controllers
{
    public class SeleniumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //LoginButton button Login
        //Google button Login with Google
        //Facebook button Login with Facebook
        //identifierId khung input tai khoan gg
        // "VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc"
        // tren la class nut tiep theo (gg)
        //"whsOnd zHQkBf" class input password
        // Button Tiep theo van la Vfp bla bla
        //Khung Search Text id : SearchText
        //TemperatureLB class cua cái can identifi

        public void GoSelenium()
        {
            var options = new ChromeOptions();
            options.AddArguments(@"user-data-dir=c:\Users\{username}\AppData\Local\Google\Chrome\User Data\");
            ChromeDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();

            driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
            driver.Url = "https://localhost:44375/";
            driver.Navigate();
            var LoginButton = driver.FindElementById("LoginButton");
            LoginButton.Click();

            var LoginWithGoogle = driver.FindElementById("Google");
            LoginWithGoogle.Click();

            var TK_Input = driver.FindElementById("identifierId");
            TK_Input.SendKeys("leminhtu25@gmail.com");

            var Next_Button = driver.FindElementByClassName("VfPpkd-RLmnJb");
            Next_Button.Click();

            var MK_input = driver.FindElementByClassName("whsOnd zHQkBf");
            MK_input.SendKeys("TrapFelix");

            Next_Button.Click();
            
            driver.Close();
        }
    }
}
