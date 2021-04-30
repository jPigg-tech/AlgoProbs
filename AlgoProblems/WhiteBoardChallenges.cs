using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class WhiteBoardChallenges
    {

        public static bool IsPinValid(string pin)
        {
            if (Int32.TryParse(pin, out int numValue) == true)
            {
                if (pin.Length == 4 || pin.Length == 6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
