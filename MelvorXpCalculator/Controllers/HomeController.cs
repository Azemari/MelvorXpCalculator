using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Diagnostics;

using MelvorXpCalculator.Models;
using MelvorXpCalculator.Utilities;
using System.Collections.Generic;

namespace MelvorXpCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //First Visit, set Consent cookie
            if(Request.Cookies["Consent"] == null)
            {
                CookieOptions option = new();
                option.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("Consent", "False", option);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Modifiers(XPModifiers form)
        {
            int totalBonus = 0;

            if (form.AncientRingOfSkills)
                totalBonus += 8;
            if (form.Pyro)
                totalBonus += 1;
            if (form.Skillcape)
                totalBonus += 5;
            if (form.PitJump)
                totalBonus += 1;
            if (form.TreeClimb)
                totalBonus += 3;
            if (form.ALovelyJog)
                totalBonus += 5;
            if (form.TreeHang)
                totalBonus += 6;
            if (form.CoalStone)
                totalBonus += -4;
            if (form.TreeBalance)
                totalBonus += -4;
            if (form.WaterTrap)
                totalBonus += -6;

            if (Request.Cookies["Consent"] == "true")
            {
                //Update Cookie Data
                CookieOptions options = new();
                options.Expires = DateTime.Now.AddYears(1);

                //Get each modifier and save them to the cookies (for retrieval) and update the GlobalViewModel
                Response.Cookies.Append("AncientRingOfSkills", form.AncientRingOfSkills.ToString(), options);
                Response.Cookies.Append("Pyro", form.Pyro.ToString(), options);
                Response.Cookies.Append("Skillcape", form.Skillcape.ToString(), options);
                Response.Cookies.Append("PitJump", form.PitJump.ToString(), options);
                Response.Cookies.Append("TreeClimb", form.TreeClimb.ToString(), options);
                Response.Cookies.Append("ALovelyJog", form.ALovelyJog.ToString(), options);
                Response.Cookies.Append("TreeHang", form.TreeHang.ToString(), options);
                Response.Cookies.Append("CoalStone", form.CoalStone.ToString(), options);
                Response.Cookies.Append("TreeBalance", form.TreeBalance.ToString(), options);
                Response.Cookies.Append("WaterTrap", form.WaterTrap.ToString(), options);
                Response.Cookies.Append("totalBonus", totalBonus.ToString(), options);
            }

            var viewModel = new GlobalViewModel()
            {
                ModifiersBonus = totalBonus
            };
            return View("Index", viewModel);
        }

        public IActionResult Modifiers()
        {
            if(Request.Cookies["Consent"] == "true")
            {
                var viewModel = new XPModifiers
                {
                    AncientRingOfSkills = Convert.ToBoolean(Request.Cookies["AncientRingOfSkills"]),
                    Pyro = Convert.ToBoolean(Request.Cookies["Pyro"]),
                    Skillcape = Convert.ToBoolean(Request.Cookies["Skillcape"]),
                    PitJump = Convert.ToBoolean(Request.Cookies["PitJump"]),
                    TreeClimb = Convert.ToBoolean(Request.Cookies["TreeClimb"]),
                    ALovelyJog = Convert.ToBoolean(Request.Cookies["ALovelyJog"]),
                    TreeHang = Convert.ToBoolean(Request.Cookies["TreeHang"]),
                    CoalStone = Convert.ToBoolean(Request.Cookies["CoalStone"]),
                    TreeBalance = Convert.ToBoolean(Request.Cookies["TreeBalance"]),
                    WaterTrap = Convert.ToBoolean(Request.Cookies["WaterTrap"])
                };
                return View(viewModel);
            }
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

        private GlobalViewModel ConstructGlobalViewModelFromCookie()
        {
            return new GlobalViewModel
            {
            };
        }

    }
}
