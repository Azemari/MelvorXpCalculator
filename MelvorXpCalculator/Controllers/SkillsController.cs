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
        #region Woodcutting
        public IActionResult Woodcutting(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Woodcutting",
                ImageUrl = "/Images/Skills/Woodcutting.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["WoodcuttingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["WoodcuttingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["WoodcuttingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["WoodcuttingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["WoodcuttingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Woodcutting")
            };

            return View(viewModel);
        }
        #endregion Woodcutting
        #region Fishing
        public IActionResult Fishing(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Fishing",
                ImageUrl = "/Images/Skills/Fishing.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["FishingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["FishingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["FishingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["FishingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["FishingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Fishing")
            };

            return View(viewModel);
        }
        #endregion Fishing
        #region Firemaking
        public IActionResult Firemaking(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Firemaking",
                ImageUrl = "/Images/Skills/Firemaking.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["FiremakingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["FiremakingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["FiremakingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["FiremakingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["FiremakingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Firemaking")
            };

            return View(viewModel);
        }
        #endregion Firemaking
        #region Cooking
        public IActionResult Cooking(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Cooking",
                ImageUrl = "/Images/Skills/Cooking.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["CookingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["CookingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["CookingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["CookingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["CookingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Cooking")
            };

            return View(viewModel);
        }
        #endregion Cooking
        #region Mining
        public IActionResult Mining(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Mining",
                ImageUrl = "/Images/Skills/Mining.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["MiningLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["MiningXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["MiningTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["MiningTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["MiningGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Mining")
            };

            return View(viewModel);
        }
        #endregion Mining
        #region Smithing
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
                catch
                {
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
        #endregion Smithing
        #region Thieving
        public IActionResult Thieving(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Thieving",
                ImageUrl = "/Images/Skills/Thieving.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["ThievingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["ThievingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["ThievingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["ThievingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["ThievingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Thieving")
            };

            return View(viewModel);
        }
        #endregion Thieving
        #region Farming
        public IActionResult Farming(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Farming",
                ImageUrl = "/Images/Skills/Farming.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["FarmingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["FarmingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["FarmingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["FarmingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["FarmingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Farming")
            };

            return View(viewModel);
        }
        #endregion Farming
        #region Fletching
        public IActionResult Fletching(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Fletching",
                ImageUrl = "/Images/Skills/Fletching.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["FletchingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["FletchingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["FletchingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["FletchingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["FletchingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Fletching")
            };

            return View(viewModel);
        }
        #endregion Fletching
        #region Crafting
        public IActionResult Crafting(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Crafting",
                ImageUrl = "/Images/Skills/Crafting.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["CraftingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["CraftingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["CraftingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["CraftingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["CraftingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Crafting")
            };

            return View(viewModel);
        }
        #endregion Crafting
        #region Runecrafting
        public IActionResult Runecrafting(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Runecrafting",
                ImageUrl = "/Images/Skills/Runecrafting.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["RunecraftingLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["RunecraftingXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["RunecraftingTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["RunecraftingTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["RunecraftingGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Runecrafting")
            };

            return View(viewModel);
        }
        #endregion Runecrafting
        #region Herblore
        public IActionResult Herblore(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Herblore",
                ImageUrl = "/Images/Skills/Herblore.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["HerbloreLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["HerbloreXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["HerbloreTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["HerbloreTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["HerbloreGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Herblore")
            };

            return View(viewModel);
        }
        #endregion Herblore
        #region Agility
        public IActionResult Agility(GlobalViewModel globalViewModel)
        {
            Skill skill = new()
            {
                Name = "Agility",
                ImageUrl = "/Images/Skills/Agility.svg"
            };

            //If we have consent, get the data
            if (Request.Cookies["Consent"] == "true")
            {
                try
                {
                    skill.Level = int.Parse(Request.Cookies["AgilityLevel"]);
                    skill.Xp = float.Parse(Request.Cookies["AgilityXp"]);
                    skill.TargetLevel = int.Parse(Request.Cookies["AgilityTargetLevel"]);
                    skill.TargetXp = float.Parse(Request.Cookies["AgilityTargetXp"]);
                    skill.Gloves = bool.Parse(Request.Cookies["AgilityGloves"]);
                }
                catch
                {
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

            SkillViewModel viewModel = new()
            {
                ModifierBonus = globalViewModel.ModifiersBonus,
                Skill = skill,
                Items = Data.RetrieveItems("Agility")
            };

            return View(viewModel);
        }
        #endregion Agility
    }
}
