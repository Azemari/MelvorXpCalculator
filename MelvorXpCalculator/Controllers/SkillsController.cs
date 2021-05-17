using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MelvorXpCalculator.Models;
using MelvorXpCalculator.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace MelvorXpCalculator.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Smithing(GlobalViewModel globalViewModel)
        {
            if(globalViewModel.ModifiersBonus == 0)
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
                Skill = Data.RetrieveSkill("Smithing"),
                Items = Data.RetrieveItems("Smithing")
            };

            return View(viewModel);
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
