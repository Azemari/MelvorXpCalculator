using System;

namespace MelvorXpCalculator.Utilities
{
    public static class GetActionTime
    {
        //10000000 = 1 second in ticks
        public static TimeSpan PerAction(string category)
        {
            switch(category)
            {
                case "Cooking":
                    return new TimeSpan(30000000);
                case "Smithing":
                    return new TimeSpan(20000000);
            }
            throw new Exception("Category provided does not exist in GetActionTime class");
        }
    }
}
