using System;

namespace MelvorXpCalculator.Utilities
{
    public static class Xp
    {
        /// <summary>
        /// Returns the xp required to reach the provided level
        /// </summary>
        public static int GetExperience(int level)
        {
            double total = 0;
            for (int i = 1; i < level; i++)
            {
                total += Math.Floor(i + 300 * Math.Pow(2, i / 7.0));
            }

            return (int)Math.Floor(total / 4);
        }

        /// <summary>
        /// Returns the level the player would be with the provided xp
        /// </summary>
        public static int GetLevel(int experience)
        {
            int index;

            for (index = 0; index < 120; index++)
            {
                if (GetExperience(index + 1) > experience)
                    break;
            }

            return index;
        }
    }
}
