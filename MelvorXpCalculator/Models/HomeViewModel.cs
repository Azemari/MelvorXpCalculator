using System.Collections.Generic;

namespace MelvorXpCalculator.Models
{
    public class SkillViewModel
    {
        public int ModifierBonus { get; set; }
        public Skill Skill { get; set; }
        public List<Item> Items { get; set; }
    }
}
