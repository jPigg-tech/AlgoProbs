﻿using System;
using System.Collections.Generic;
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
    }
}
