using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    public class ReverseAnArray
    {
        public char[] ReverseArray(params char[] array)
        {
            


            char[] reversedArray = new char[array.Length];
            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] = array[i];
            }
            return reversedArray;
        }

        // w/ out array.Length 
        // int h = 0;
        // foreach(char item in array)
        // {
        //    h++;
        // }
        // Then set reversedArray = new char [ h ]
        // and in the for loop , instead of array.Length , do h - 1
    }
}
