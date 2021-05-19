using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class CheckPalindromeModulus
    {
        public bool CheckPalindrome(int number)
        {
            int n = number;
            int rev = 0;
            while (number > 0)
            {
                int dig = number % 10;
                rev = rev * 10 + dig;
                number = number / 10;
            }
            if (number == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
