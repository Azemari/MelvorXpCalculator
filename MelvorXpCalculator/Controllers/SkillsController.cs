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
        private static GlobalModifiers GetGlobalModifiers()
        {
            var modifiersJson = Data.Retrieve<Modifier>("XPModifiers.json");

            int xpBonus = 0;
            foreach (var modifier in modifiersJson)
            {
                if (modifier.Active)
                    xpBonus += modifier.Effect;
            };

            return new GlobalModifiers
            {
                Modifiers = modifiersJson,
                TotalXpModifier = xpBonus
            };
        }

        public IActionResult Smithing(GlobalViewModel globalViewModel)
        {
            HomeViewModel viewModel = new()
            {
                Modifiers = GetGlobalModifiers(),
                Skill = Data.RetrieveSkill("Smithing"),
                Items = Data.RetrieveItems("Smithing")
            };

            return View(viewModel);
        }
    }
}
