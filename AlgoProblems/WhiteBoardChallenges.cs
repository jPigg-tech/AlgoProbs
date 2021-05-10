using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoProblems
{
    public class WhiteBoardChallenges
    {
        public bool IsPinValid(string pin)
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

        // The method should take in a string and check if the string
        // is all numbers and is either 4 or 6 digits for it to 
        // be a valid pin
    }
}
