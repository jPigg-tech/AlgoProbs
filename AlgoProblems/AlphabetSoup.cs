using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoProblems
{
    class AlphabetSoup
    {
        public string GetAlphabetSoup(string str)
        {
            //string newWord;
            //var wordArray = new char[word.Length];
            //var wordArray2 = new List<char>();
            //for (int i = 0; i < word.Length - 1; i++)
            //{
            //    wordArray2.Add(word[i]);
            //}

            //wordArray2.Sort();
            //// string newWord = wordArray2.ToString();
            //foreach (var character in wordArray2)
            //{

            //}

            //return newWord;


            // return String.Concat(str.OrderBy(s => s));

            char[] chArray = str.ToArray();
            int length = chArray.Length;
            char ch = ' ';
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (chArray[i] > chArray[j])
                    {
                        ch = chArray[i];
                        chArray[i] = chArray[j];
                        chArray[j] = ch;
                    }
                }
            }
            return new string(chArray);


        }
    }
}
