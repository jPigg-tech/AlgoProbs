using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProblems
{
    public class Rot13
    {
        public string GetRot13(string message)
        {
            StringBuilder newString = new StringBuilder("", 100);
            //A = 65, Z = 90
            //a = 97, z = 122
            foreach (var character in message)
            {
                if (Char.IsLetter(character))
                {
                    int firstLetter = 97;
                    if (character <= 90)
                        firstLetter = 65;
                    if (character >= firstLetter + 13)
                        newString.Append((char)(character - (firstLetter + 25) + (firstLetter - 1) + 13));
                    else
                        newString.Append((char)(character + 13));
                }
                else
                    newString.Append(character);
            }
            return newString.ToString();
        }

        // ROT13 replaces a letter with the 13th letter after it in the alphabet
        // if a letter passes Z the next consecutive letter is A
    }
}
