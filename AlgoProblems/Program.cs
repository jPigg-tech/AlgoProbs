using System;

namespace AlgoProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
