using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    public class SameEnding
    {
        public bool IsEndingSame (string str, string ending)
        {
            if (str.Length <= ending.Length)
            {
                return false;
            }

            for (int i = str.Length - 1, j = ending.Length - 1; j >= 0; i--, j--)
            {
                if (Char.ToLower(str[i]) != Char.ToLower(ending[j]))
                {
                    return false;
                }
            }
            return true;

            // This method takes in two strings and the second string needs to be 
            // equal to the ending of the first string 
            
        }
        // or you can use
        // return (str.Length < ending.Length) ? false : str.Substring(str.Length - ending.Length, ending.Length) == ending;
    }
}
