using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MelvorXpCalculator.Models;
using MelvorXpCalculator.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MelvorXpCalculator.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Smithing(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Smithing",
                ImageUrl = "/Images/Skills/Smithing.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["SmithingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["SmithingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["SmithingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["SmithingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["SmithingGloves"]);
                }
                catch {
                    skill.Level = 1;
                    skill.Xp = 1;
                    skill.TargetLevel = 1;
                    skill.TargetXp = 1;
                    skill.Gloves = false;
                }
            }
            else
            {
                skill.Level = 1;
                skill.Xp = 1;
                skill.TargetLevel = 1;
                skill.TargetXp = 1;
                skill.Gloves = false;
            }

            if (int.TryParse(Request.Cookies["totalBonus"], out int totalBonus))
                globalViewModel.ModifiersBonus = totalBonus;
            if (skill.Gloves)
                globalViewModel.ModifiersBonus += 50;


            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Smithing")
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Smithing(SkillViewModel form)
        {
            form.Items = Data.RetrieveItems("Smithing");
            //Save new levels to cookie
            CookieOptions options = new();
            options.Expires = DateTime.Now.AddYears(1);

            //Get each modifier and save them to the cookies (for retrieval) and update the GlobalViewModel
            Response.Cookies.Append("SmithingLevel", form.Skill.Level.ToString(), options);
            Response.Cookies.Append("SmithingXp", form.Skill.Xp.ToString(), options);
            Response.Cookies.Append("SmithingTargetLevel", form.Skill.TargetLevel.ToString(), options);
            Response.Cookies.Append("SmithingTargetXp", form.Skill.TargetXp.ToString(), options);
            Response.Cookies.Append("SmithingGloves", form.Skill.Gloves.ToString(), options);

            return View(form);
        }

        public IActionResult Cooking(GlobalViewModel globalViewModel)
        {
            if (globalViewModel.ModifiersBonus == 0)
            {
                try
                {
                    globalViewModel.ModifiersBonus = int.Parse(Request.Cookies["totalBonus"]);
                }
                catch { }
            }


            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = Data.RetrieveSkill("Cooking"),
                Items = Data.RetrieveItems("Cooking")
            };

            return View(viewModel);
        }
    }
}
