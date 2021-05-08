using System.Collections.Generic;

namespace MelvorXpCalculator.Models
{
    public class GlobalModifiers
    {
        public List<Modifier> Modifiers { get; set; }
        public int TotalXpModifier { get; set; }
    }

    public struct Modifier
    {
        public string Name;
        public string ImageUrl;
        public bool Active;
        public int Effect;
    }
}
