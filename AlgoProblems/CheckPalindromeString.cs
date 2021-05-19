using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class CheckPalindromeString
    {

        public bool CheckIfPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            // remove empty spaces 

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    return false;
            }
            return true;
        }

        public string ReturnPalindromeString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "false";
            }

            char[] myArray = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                myArray[i] = str[i];
            }

            char[] reversedArray = new char[str.Length];
            for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] = myArray[i];
            }

            if (reversedArray.ToString() == myArray.ToString())
            {
                return "true";
            }
            return "false";
        }
    }
}
