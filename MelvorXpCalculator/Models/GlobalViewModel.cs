using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MelvorXpCalculator.Models
{
    public class GlobalViewModel
    {
        public byte[] SkillsFile { get; set; }
        public byte[] ModifiersFile { get; set; }

        public List<Modifier> Modifiers { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
