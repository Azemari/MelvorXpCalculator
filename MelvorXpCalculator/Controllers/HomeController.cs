using System.Diagnostics;
using MelvorXpCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using MelvorXpCalculator.Utilities;
using Microsoft.AspNetCore.Http;
using System;

namespace MelvorXpCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //First Visit, set ID and Consent cookies
            if(Request.Cookies["Consent"] == null)
            {
                CookieOptions option = new();
                option.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("Consent", "False", option);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(GlobalViewModel model)
        {

            var viewModel = new GlobalViewModel()
            {
                Modifiers = Data.Retrieve<Modifier>("XPModifiers.json")
            };

            return View(viewModel);
        }

        public IActionResult Modifiers()
        {
            return View();
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
