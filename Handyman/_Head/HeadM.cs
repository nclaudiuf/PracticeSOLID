using System.Collections.Generic;

namespace Handyman._Head
{
    public static class HeadM
    {
        public enum ArmActions
        {
            Up = 1, Down = -1, Stop = 0
        }

        public static Dictionary<int, string> armActions = new Dictionary<int, string>()
        {
            {1, "Moving arm up" },
            {-1, "Moving arm down" },
            {0, "" }
        };
    }
}
