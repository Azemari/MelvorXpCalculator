using System.Diagnostics;
using System.Collections.Generic;
using MelvorXpCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using MelvorXpCalculator.Utilities;

namespace MelvorXpCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(GlobalViewModel model)
        {
            var viewModel = new GlobalViewModel()
            {
                Modifiers = Data.Retrieve<Modifier>("XPModifiers.json")
            };

            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
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
