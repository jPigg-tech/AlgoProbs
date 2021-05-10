using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoProblems
{
    public class Isogram
    {
        public bool IsIsogram(string str)
        {
            if (str.ToLower().Distinct().Count() == str.Length)
            {
                return true;
            }
            return false;
        }

        // An isogram is a word that has no repeating letters,
        // consecutive or non-consecutive.

        // Implement a function that determines whether
        // a string that contains only letters is an isogram.
        // Assume the empty string is an isogram. Ignore letter case.
    }
}
