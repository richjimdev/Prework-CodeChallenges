using System;

namespace PreworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengeOne();
        }

        static void ChallengeOne()
        {
            Random rng = new Random();
            int[] randArray = { rng.Next(1, 10),
                rng.Next(1, 10),
                rng.Next(1, 10),
                rng.Next(1, 10),
                rng.Next(1, 10) };
            Console.WriteLine(string.Join(", ", randArray));
            Console.ReadLine();
        }
    }
}
