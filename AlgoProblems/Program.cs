using System;

namespace AlgoProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var isogram = new Isogram();

            Console.WriteLine(isogram.IsIsogram("Jeff"));
            Console.WriteLine(isogram.IsIsogram("ambidextrously"));
            Console.WriteLine(isogram.IsIsogram("trust"));
        }
        
        static void RunReverseArray()
        {
            var anArray = new ReverseAnArray();

            Console.WriteLine(anArray.ReverseArray('1', '2', '3', '4'));
            Console.WriteLine(anArray.ReverseArray('f', 'f', '3', 'J'));
        }

        static void RunISPinValidMethod()
        {
            var challenge = new WhiteBoardChallenges();

            Console.WriteLine(challenge.IsPinValid("1234"));
            Console.WriteLine(challenge.IsPinValid("1b34"));
            Console.WriteLine(challenge.IsPinValid("12345"));
            Console.WriteLine(challenge.IsPinValid("123456"));
        }
    }
}
