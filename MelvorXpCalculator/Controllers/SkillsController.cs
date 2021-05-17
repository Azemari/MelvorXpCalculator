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
            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = Data.RetrieveSkill("Smithing"),
                Items = Data.RetrieveItems("Smithing")
            };

            return View(viewModel);
        }
    }
}
