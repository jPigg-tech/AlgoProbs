using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    class StringToArray
    {
        public char[] StringToCharArray(string myString)
        {
            ////string myString = "myString";
            char[] myArray = new char[myString.Length];
            for (int i = 0; i < myString.Length; i++)
            {
                myArray[i] = myString[i];
            }
            return myArray;
        }
    }
}
