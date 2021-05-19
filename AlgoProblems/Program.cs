using System;

namespace AlgoProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabetSoup = new AlphabetSoup();

            Console.WriteLine(alphabetSoup.GetAlphabetSoup("hello"));
        }

        static void RunRunningSumArray()
        {
            var runningSumArray = new RunnningSumArray();

            foreach (var number in runningSumArray.RunningSum(1, 2, 3, 4))
            {
                Console.WriteLine(number);
            }


            foreach (var number in runningSumArray.RunningSum(1, 1, 1, 1))
            {
                Console.WriteLine(number);
            }
        }

        static void RunRot13()
        {
            var rot13 = new Rot13();

            Console.WriteLine(rot13.GetRot13("hello"));
            // 'hello' == 'uryyb'
        }

        static void RunIsEndingSame()
        {
            var sameEnding = new SameEnding();

            Console.WriteLine(sameEnding.IsEndingSame("Jeff", "ff"));
            Console.WriteLine(sameEnding.IsEndingSame("abc", "d"));
            Console.WriteLine(sameEnding.IsEndingSame("abcd", "bcd"));
            Console.WriteLine(sameEnding.IsEndingSame("a", "a"));
        }

        static void RunIsIsogram()
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
