using System.Collections.Generic;

namespace MelvorXpCalculator.Models
{
    public class HomeViewModel
    {
        public GlobalModifiers Modifiers { get; set; }
        public Skill Skill { get; set; }
        public List<Item> Items { get; set; }
    }
}
