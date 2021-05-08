using System.Collections.Generic;

namespace MelvorXpCalculator.Models
{
    public class Item : BaseItem
    {
        public string Category { get; set; }
#nullable enable
        public string? SubCategory { get; set; }
#nullable disable
        public int Xp { get; set; }
        public List<BaseItem> Requirements  { get; set; }
    }
}
