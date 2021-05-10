using System;

namespace AlgoProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenge = new WhiteBoardChallenges();

            Console.WriteLine(challenge.ReverseArray('1', '2', '3', '4'));
            Console.WriteLine(challenge.ReverseArray('f', 'f', '3', 'J'));
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
