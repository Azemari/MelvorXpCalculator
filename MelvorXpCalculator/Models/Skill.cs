namespace MelvorXpCalculator.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public float Xp { get; set; }
        public int Level { get; set; }
        public float TargetXp { get; set; }
        public int TargetLevel { get; set; }
        public bool Gloves { get; set; }
    }
}
